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
            Database.EnsureCreated();
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }

        // TODO: make the enums strings
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExerciseMuscleGroup>()
                .HasKey(t => new { t.ExerciseId, t.MuscleGroupId });
        }
    }
}
