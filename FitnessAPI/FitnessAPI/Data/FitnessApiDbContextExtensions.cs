using FitnessAPI.Entities;
using FitnessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

            var exerciseSeedData = new List<ExerciseSeedData>();
            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Squat",
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads,
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell,
                    LiftingEquipmentType.PowerRack,
                    LiftingEquipmentType.SquatRack
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Bench Press",
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Chest,
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell,
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Deadlift",
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.LowerBack,
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Forearms,
                    MuscleGroupType.Traps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            var exercises = new List<Exercise>();

            foreach (ExerciseSeedData n in exerciseSeedData)
            {
                exercises.Add(new Exercise()
                {
                    Name = n.ExerciseName
                });
            }

            context.Exercises.AddRange(exercises);
            context.SaveChanges();

            var muscleGroups = new List<MuscleGroup>();
            foreach(MuscleGroupType m in Enum.GetValues(typeof(MuscleGroupType)))
            {
                muscleGroups.Add(new MuscleGroup()
                {
                    MuscleGroupType = m
                });
            }

            context.MuscleGroups.AddRange(muscleGroups);
            context.SaveChanges();

            ExerciseMuscleGroup CreateExerciseMuscleGroup(string name, MuscleGroupType muscleGroupType)
            {
                return new ExerciseMuscleGroup
                {
                    ExerciseId = exercises.Single(e => e.Name == name).ExerciseId,
                    MuscleGroupId = muscleGroups.Where(
                        m => m.MuscleGroupType == muscleGroupType
                    ).FirstOrDefault().MuscleGroupId
                };
            }

            var exerciseMuscleGroups = new List<ExerciseMuscleGroup>();

            foreach (ExerciseSeedData e in exerciseSeedData)
            {
                foreach (MuscleGroupType m in e.MuscleGroupTypes)
                {
                    exerciseMuscleGroups.Add(
                        CreateExerciseMuscleGroup(e.ExerciseName, m));
                }
            }

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

            ExerciseLiftingEquipment CreateNewExerciseLiftingEquipment(string name, LiftingEquipmentType liftingEquipmentType)
            {
                return new ExerciseLiftingEquipment
                {
                    ExerciseId = exercises.Single(e => e.Name == name).ExerciseId,
                    LiftingEquipmentId = liftingEquipment.Where(
                        l => l.LiftingEquipmentType == liftingEquipmentType
                    ).FirstOrDefault().LiftingEquipmentId
                };
            }

            var exerciseLiftingEquipment = new List<ExerciseLiftingEquipment>();

            foreach (ExerciseSeedData e in exerciseSeedData)
            {
                foreach (LiftingEquipmentType l in e.LiftingEquipmentTypes)
                {
                    exerciseLiftingEquipment.Add(CreateNewExerciseLiftingEquipment(e.ExerciseName, l));
                }
            }

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
