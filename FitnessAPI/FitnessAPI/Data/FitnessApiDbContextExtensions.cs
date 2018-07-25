using FitnessAPI.Models;
using FitnessAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Data
{
    public static class FitnessApiDbContextExtensions
    {
        public static void EnsureSeedDataForContext(this FitnessApiDbContext context)
        {
            if (context.Exercises.Any())
            {
                return;
            }

            var exercises = new List<Entities.Exercise>()
            {
                new Entities.Exercise()
                {
                    Name = "Squat"
                },
                new Entities.Exercise()
                {
                    Name = "Bench Press"
                },
                new Entities.Exercise()
                {
                    Name = "Deadlift"
                }
            };

            context.Exercises.AddRange(exercises);
            context.SaveChanges();

            var muscleGroups = new List<MuscleGroup>()
            {
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.Quads
                },
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.Hamstrings
                },
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.Glutes
                },
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.Chest
                },
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.Shoulders
                },
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.Triceps
                },
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.LowerBack
                },
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.Traps
                },
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.Forearms
                },
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.Abs
                },
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.Back
                },
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.Biceps
                },
                new MuscleGroup()
                {
                    MuscleGroupType = MuscleGroupType.Calves
                }
            };

            context.MuscleGroups.AddRange(muscleGroups);
            context.SaveChanges();

            var exerciseMuscleGroups = new List<ExerciseMuscleGroup>()
            {
                new ExerciseMuscleGroup
                {
                    ExerciseId = exercises.Single(e => e.Name == "Squat").ExerciseId,
                    MuscleGroupId = muscleGroups.Where(
                        m => m.MuscleGroupType == MuscleGroupType.Quads
                    ).FirstOrDefault().MuscleGroupId
                },
                new ExerciseMuscleGroup
                {
                    ExerciseId = exercises.Single(e => e.Name == "Squat").ExerciseId,
                    MuscleGroupId = muscleGroups.Where(
                        m => m.MuscleGroupType == MuscleGroupType.Hamstrings
                    ).FirstOrDefault().MuscleGroupId
                },
                new ExerciseMuscleGroup
                {
                    ExerciseId = exercises.Single(e => e.Name == "Squat").ExerciseId,
                    MuscleGroupId = muscleGroups.Where(
                        m => m.MuscleGroupType == MuscleGroupType.Glutes
                    ).FirstOrDefault().MuscleGroupId
                },
                new ExerciseMuscleGroup
                {
                    ExerciseId = exercises.Single(e => e.Name == "Bench Press").ExerciseId,
                    MuscleGroupId = muscleGroups.Where(
                        m => m.MuscleGroupType == MuscleGroupType.Chest
                    ).FirstOrDefault().MuscleGroupId
                },
                new ExerciseMuscleGroup
                {
                    ExerciseId = exercises.Single(e => e.Name == "Bench Press").ExerciseId,
                    MuscleGroupId = muscleGroups.Where(
                        m => m.MuscleGroupType == MuscleGroupType.Shoulders
                    ).FirstOrDefault().MuscleGroupId
                },
                new ExerciseMuscleGroup
                {
                    ExerciseId = exercises.Single(e => e.Name == "Bench Press").ExerciseId,
                    MuscleGroupId = muscleGroups.Where(
                        m => m.MuscleGroupType == MuscleGroupType.Triceps
                    ).FirstOrDefault().MuscleGroupId
                },
                new ExerciseMuscleGroup
                {
                    ExerciseId = exercises.Single(e => e.Name == "Deadlift").ExerciseId,
                    MuscleGroupId = muscleGroups.Where(
                        m => m.MuscleGroupType == MuscleGroupType.LowerBack
                    ).FirstOrDefault().MuscleGroupId
                },
                new ExerciseMuscleGroup
                {
                    ExerciseId = exercises.Single(e => e.Name == "Deadlift").ExerciseId,
                    MuscleGroupId = muscleGroups.Where(
                        m => m.MuscleGroupType == MuscleGroupType.Hamstrings
                    ).FirstOrDefault().MuscleGroupId
                },
                new ExerciseMuscleGroup
                {
                    ExerciseId = exercises.Single(e => e.Name == "Deadlift").ExerciseId,
                    MuscleGroupId = muscleGroups.Where(
                        m => m.MuscleGroupType == MuscleGroupType.Traps
                    ).FirstOrDefault().MuscleGroupId
                },
                new ExerciseMuscleGroup
                {
                    ExerciseId = exercises.Single(e => e.Name == "Deadlift").ExerciseId,
                    MuscleGroupId = muscleGroups.Where(
                        m => m.MuscleGroupType == MuscleGroupType.Forearms
                    ).FirstOrDefault().MuscleGroupId
                }
            };

            foreach (ExerciseMuscleGroup e in exerciseMuscleGroups)
            {
                var exerciseMuscleGroupInDb = context.ExerciseMuscleGroups.Where(
                    s =>
                        s.Exercise.ExerciseId == e.ExerciseId &&
                        s.MuscleGroup.MuscleGroupId == e.MuscleGroupId).SingleOrDefault();
                if (exerciseMuscleGroupInDb == null)
                {
                    context.ExerciseMuscleGroups.Add(e);
                }
            }

            context.SaveChanges();

            var liftingEquipment = new List<LiftingEquipment>();
            foreach (LiftingEquipmentType l in Enum.GetValues(typeof(LiftingEquipmentType)))
            {
                liftingEquipment.Add(new LiftingEquipment()
                {
                    LiftingEquipmentType = l
                });
            }

            context.LiftingEquipment.AddRange(liftingEquipment);
            context.SaveChanges();

            var exerciseLiftingEquipment = new List<ExerciseLiftingEquipment>()
            {
                new ExerciseLiftingEquipment
                {
                    ExerciseId = exercises.Single(e => e.Name == "Squat").ExerciseId,
                    LiftingEquipmentId = liftingEquipment.Where(
                        l => l.LiftingEquipmentType == LiftingEquipmentType.Barbell
                    ).FirstOrDefault().LiftingEquipmentId
                },
                new ExerciseLiftingEquipment
                {
                    ExerciseId = exercises.Single(e => e.Name == "Squat").ExerciseId,
                    LiftingEquipmentId = liftingEquipment.Where(
                        l => l.LiftingEquipmentType == LiftingEquipmentType.PowerRack
                    ).FirstOrDefault().LiftingEquipmentId
                },
                new ExerciseLiftingEquipment
                {
                    ExerciseId = exercises.Single(e => e.Name == "Bench Press").ExerciseId,
                    LiftingEquipmentId = liftingEquipment.Where(
                        l => l.LiftingEquipmentType == LiftingEquipmentType.Barbell
                    ).FirstOrDefault().LiftingEquipmentId
                },
                new ExerciseLiftingEquipment
                {
                    ExerciseId = exercises.Single(e => e.Name == "Bench Press").ExerciseId,
                    LiftingEquipmentId = liftingEquipment.Where(
                        l => l.LiftingEquipmentType == LiftingEquipmentType.FlatBench
                    ).FirstOrDefault().LiftingEquipmentId
                },
                new ExerciseLiftingEquipment
                {
                    ExerciseId = exercises.Single(e => e.Name == "Deadlift").ExerciseId,
                    LiftingEquipmentId = liftingEquipment.Where(
                        l => l.LiftingEquipmentType == LiftingEquipmentType.Barbell
                    ).FirstOrDefault().LiftingEquipmentId
                }
            };

            foreach (ExerciseLiftingEquipment e in exerciseLiftingEquipment)
            {
                var exerciseLiftingEquipmentInDb = context.ExerciseLiftingEquipment.Where(
                    s =>
                        s.Exercise.ExerciseId == e.ExerciseId &&
                        s.LiftingEquipment.LiftingEquipmentId == e.LiftingEquipmentId).SingleOrDefault();
                if (exerciseLiftingEquipmentInDb == null)
                {
                    context.ExerciseLiftingEquipment.Add(e);
                }
            }

            context.SaveChanges();
        }
    }
}
