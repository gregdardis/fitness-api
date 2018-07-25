using FitnessAPI.Data;
using FitnessAPI.Models;
using FitnessAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace FitnessAPI
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FitnessApiDbContext>(
                options => options.UseSqlServer(_configuration.GetConnectionString("FitnessApi"))
            );
            services.AddScoped<IExerciseRepository, ExerciseRepository>();
            services.AddScoped<IMuscleGroupRepository, MuscleGroupRepository>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            FitnessApiDbContext fitnessApiDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            // could be buggy if called here
            fitnessApiDbContext.EnsureSeedDataForContext();

            app.UseHttpsRedirection();

            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entities.Exercise, ExerciseWithoutMuscleGroupsOrEquipmentDto>();
                cfg.CreateMap<Entities.Exercise, ExerciseDto>().ForMember(
                    dest => dest.MuscleGroups, opt => opt.MapFrom(
                        src => src.ExerciseMuscleGroups
                            .Select(emg => emg.MuscleGroup.MuscleGroupType.ToString())));
                cfg.CreateMap<IEnumerable<Entities.MuscleGroup>, IEnumerable<string>>().ConvertUsing(
                    m => m.Select(mg => mg.MuscleGroupType.ToString()));
            });

            app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "api/{controller=Exercises}/{action=Index}");
        }
    }
}
