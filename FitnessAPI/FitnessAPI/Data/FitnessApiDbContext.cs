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

        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }

        // TODO: make the enums strings
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Exercise>()
            //    .HasMany(a => a.MuscleGroups)
            //    .WithOne()
            //    .HasForeignKey(MuscleGroups)
            //modelBuilder.Entity<MuscleGroup>()
            //    .HasKey(x => new { x.ExerciseId });

            //modelBuilder.Entity<MuscleGroup>()
            //    .HasMany(x => x.)
            //modelBuilder.Entity<MuscleGroup>().ToTable("MuscleGroup");
            modelBuilder.Entity<MuscleGroup>()
                .HasOne(e => e.Exercise)
                .WithMany(m => m.MuscleGroups)
                .HasForeignKey(e => e.ExerciseId);
        }
    }
}
