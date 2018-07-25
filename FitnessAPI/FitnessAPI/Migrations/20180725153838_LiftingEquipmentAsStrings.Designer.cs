﻿// <auto-generated />
using FitnessAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FitnessAPI.Migrations
{
    [DbContext(typeof(FitnessApiDbContext))]
    [Migration("20180725153838_LiftingEquipmentAsStrings")]
    partial class LiftingEquipmentAsStrings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FitnessAPI.Entities.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("VideoURL");

                    b.HasKey("ExerciseId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("FitnessAPI.Entities.ExerciseLiftingEquipment", b =>
                {
                    b.Property<int>("ExerciseId");

                    b.Property<int>("LiftingEquipmentId");

                    b.HasKey("ExerciseId", "LiftingEquipmentId");

                    b.HasIndex("LiftingEquipmentId");

                    b.ToTable("ExerciseLiftingEquipment");
                });

            modelBuilder.Entity("FitnessAPI.Entities.ExerciseMuscleGroup", b =>
                {
                    b.Property<int>("ExerciseId");

                    b.Property<int>("MuscleGroupId");

                    b.HasKey("ExerciseId", "MuscleGroupId");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("ExerciseMuscleGroups");
                });

            modelBuilder.Entity("FitnessAPI.Entities.LiftingEquipment", b =>
                {
                    b.Property<int>("LiftingEquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LiftingEquipmentType")
                        .IsRequired();

                    b.HasKey("LiftingEquipmentId");

                    b.HasAlternateKey("LiftingEquipmentType");

                    b.ToTable("LiftingEquipment");
                });

            modelBuilder.Entity("FitnessAPI.Entities.MuscleGroup", b =>
                {
                    b.Property<int>("MuscleGroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MuscleGroupType")
                        .IsRequired();

                    b.HasKey("MuscleGroupId");

                    b.HasAlternateKey("MuscleGroupType");

                    b.ToTable("MuscleGroups");
                });

            modelBuilder.Entity("FitnessAPI.Entities.ExerciseLiftingEquipment", b =>
                {
                    b.HasOne("FitnessAPI.Entities.Exercise", "Exercise")
                        .WithMany("ExerciseLiftingEquipment")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessAPI.Entities.LiftingEquipment", "LiftingEquipment")
                        .WithMany("ExerciseLiftingEquipment")
                        .HasForeignKey("LiftingEquipmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitnessAPI.Entities.ExerciseMuscleGroup", b =>
                {
                    b.HasOne("FitnessAPI.Entities.Exercise", "Exercise")
                        .WithMany("ExerciseMuscleGroups")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessAPI.Entities.MuscleGroup", "MuscleGroup")
                        .WithMany("ExerciseMuscleGroups")
                        .HasForeignKey("MuscleGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
