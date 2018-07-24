using FitnessAPI.Entities;
using FitnessAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Data
{
    public class FitnessApiDbContext : DbContext
    {
        public FitnessApiDbContext(DbContextOptions options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Entities.Exercise> Exercises { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }
        public DbSet<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }

        // TODO: make the enums strings
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExerciseMuscleGroup>()
                .HasKey(e => new { e.ExerciseId, e.MuscleGroupId });
        }
    }
}
