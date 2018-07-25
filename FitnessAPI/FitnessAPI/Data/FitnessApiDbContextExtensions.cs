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
                ExerciseName = "High Bar Squat",
                MainMuscleGroupType = MuscleGroupType.Quads,
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
                ExerciseName = "Low Bar Squat",
                MainMuscleGroupType = MuscleGroupType.Quads,
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
                ExerciseName = "Squat",
                MainMuscleGroupType = MuscleGroupType.Quads,
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
                ExerciseName = "Box Squat",
                MainMuscleGroupType = MuscleGroupType.Quads,
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
                    LiftingEquipmentType.SquatRack,
                    LiftingEquipmentType.SquatBox
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Barbell Lunge",
                MainMuscleGroupType = MuscleGroupType.Quads,
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
                ExerciseName = "Dumbbell Lunge",
                MainMuscleGroupType = MuscleGroupType.Quads,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads,
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Goblet Squat",
                MainMuscleGroupType = MuscleGroupType.Quads,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads,
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Kettlebell Goblet Squat",
                MainMuscleGroupType = MuscleGroupType.Quads,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads,
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Kettlebell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Frankenstein Squat",
                MainMuscleGroupType = MuscleGroupType.Quads,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads,
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell,
                    LiftingEquipmentType.SquatRack,
                    LiftingEquipmentType.PowerRack
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Front Squat",
                MainMuscleGroupType = MuscleGroupType.Quads,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads,
                    MuscleGroupType.Core
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell,
                    LiftingEquipmentType.SquatRack,
                    LiftingEquipmentType.PowerRack
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Pistol Squat",
                MainMuscleGroupType = MuscleGroupType.Quads,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads,
                    MuscleGroupType.Glutes,
                    MuscleGroupType.Hamstrings
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Leg Press",
                MainMuscleGroupType = MuscleGroupType.Quads,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Leg Extension",
                MainMuscleGroupType = MuscleGroupType.Quads,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Romanian Deadlift",
                MainMuscleGroupType = MuscleGroupType.Hamstrings,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.LowerBack,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Romanian Deadlift",
                MainMuscleGroupType = MuscleGroupType.Hamstrings,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.LowerBack,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Stiff-Legged Deadlift",
                MainMuscleGroupType = MuscleGroupType.Hamstrings,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.LowerBack,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "One-Legged Deadlift",
                MainMuscleGroupType = MuscleGroupType.Hamstrings,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.LowerBack,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight,
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Floor Glute-Ham Raise",
                MainMuscleGroupType = MuscleGroupType.Hamstrings,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight,
                    LiftingEquipmentType.WorkoutPartner
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Glute-Ham Raise",
                MainMuscleGroupType = MuscleGroupType.Hamstrings,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Lying Leg Curl",
                MainMuscleGroupType = MuscleGroupType.Hamstrings,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Hamstrings
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Good Morning",
                MainMuscleGroupType = MuscleGroupType.Hamstrings,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.LowerBack
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Hyperextension",
                MainMuscleGroupType = MuscleGroupType.LowerBack,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.LowerBack
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Deficit Deadlift",
                MainMuscleGroupType = MuscleGroupType.LowerBack,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.LowerBack,
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Traps,
                    MuscleGroupType.Forearms
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Deadlift",
                MainMuscleGroupType = MuscleGroupType.LowerBack,
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

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Bent-Over Barbell Row",
                MainMuscleGroupType = MuscleGroupType.Back,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Back,
                    MuscleGroupType.LowerBack,
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Row",
                MainMuscleGroupType = MuscleGroupType.Back,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Back,
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Bench Press",
                MainMuscleGroupType = MuscleGroupType.Chest,
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

            

            var exercises = new List<Exercise>();

            foreach (ExerciseSeedData n in exerciseSeedData)
            {
                exercises.Add(new Exercise()
                {
                    Name = n.ExerciseName,
                    MainMuscleGroupType = n.MainMuscleGroupType
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
