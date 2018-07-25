using FitnessAPI.Entities;
using FitnessAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FitnessAPI.Data
{
    public class FitnessApiDbContext : DbContext
    {
        public FitnessApiDbContext(DbContextOptions options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }
        public DbSet<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }
        public DbSet<LiftingEquipment> LiftingEquipment { get; set; }
        public DbSet<ExerciseLiftingEquipment> ExerciseLiftingEquipment { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExerciseMuscleGroup>()
                .HasKey(e => new { e.ExerciseId, e.MuscleGroupId });

            modelBuilder.Entity<ExerciseLiftingEquipment>()
                .HasKey(e => new { e.ExerciseId, e.LiftingEquipmentId });

            modelBuilder.Entity<Exercise>()
                .Property(e => e.MainMuscleGroupType)
                    .HasConversion(
                        v => v.ToString(),
                        v => (MuscleGroupType)Enum.Parse(typeof(MuscleGroupType), v));

            modelBuilder.Entity<LiftingEquipment>()
                .Property(l => l.LiftingEquipmentType)
                    .HasConversion(
                        v => v.ToString(),
                        v => (LiftingEquipmentType)Enum.Parse(typeof(LiftingEquipmentType), v));

            modelBuilder.Entity<MuscleGroup>()
                .Property(m => m.MuscleGroupType)
                    .HasConversion(
                        v => v.ToString(),
                        v => (MuscleGroupType)Enum.Parse(typeof(MuscleGroupType), v));

            modelBuilder.Entity<MuscleGroup>()
                .HasAlternateKey(m => m.MuscleGroupType);

            modelBuilder.Entity<LiftingEquipment>()
                .HasAlternateKey(l => l.LiftingEquipmentType);
        }
    }
}
