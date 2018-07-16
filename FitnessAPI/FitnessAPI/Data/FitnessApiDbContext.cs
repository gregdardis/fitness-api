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
            :base(options)
        {

        }

        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Exercise>()
            //    .Property<MuscleGroup>("MuscleGroupCollection")
            //    .HasField("_muscleGroups");

            //modelBuilder.Entity<Exercise>()
            //    .Property<LiftingEquipment>("LiftingEquipmentCollection")
            //    .HasField("_liftingEquipment");
        }
    }
}
