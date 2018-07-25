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

            var namesAndMuscleGroups = new List<NameAndMuscleGroups>();
            namesAndMuscleGroups.Add(new NameAndMuscleGroups()
            {
                ExerciseName = "Squat",
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads,
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Glutes
                }
            });

            namesAndMuscleGroups.Add(new NameAndMuscleGroups()
            {
                ExerciseName = "Bench Press",
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Chest,
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                }
            });

            namesAndMuscleGroups.Add(new NameAndMuscleGroups()
            {
                ExerciseName = "Deadlift",
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.LowerBack,
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Forearms,
                    MuscleGroupType.Traps
                }
            });

            var exercises = new List<Exercise>();

            foreach (NameAndMuscleGroups n in namesAndMuscleGroups)
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

            foreach (NameAndMuscleGroups n in namesAndMuscleGroups)
            {
                foreach (MuscleGroupType m in n.MuscleGroupTypes)
                {
                    exerciseMuscleGroups.Add(
                        CreateExerciseMuscleGroup(n.ExerciseName, m));
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

            // TODO: refactor
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
