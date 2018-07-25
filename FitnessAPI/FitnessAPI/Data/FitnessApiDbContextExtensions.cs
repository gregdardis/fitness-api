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
                ExerciseName = "Bodyweight Lunge",
                MainMuscleGroupType = MuscleGroupType.Quads,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads,
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Jumping Lunge",
                MainMuscleGroupType = MuscleGroupType.Quads,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads,
                    MuscleGroupType.Hamstrings,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Kettlebell Lunge",
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
                ExerciseName = "Hip Thrust",
                MainMuscleGroupType = MuscleGroupType.Glutes,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell,
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Hip Thrust",
                MainMuscleGroupType = MuscleGroupType.Glutes,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Glute Bridge",
                MainMuscleGroupType = MuscleGroupType.Glutes,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Glute Bridge",
                MainMuscleGroupType = MuscleGroupType.Glutes,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Kettlebell Glute Bridge",
                MainMuscleGroupType = MuscleGroupType.Glutes,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Kettlebell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Cable Kickback",
                MainMuscleGroupType = MuscleGroupType.Glutes,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Cable
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Glute Pushdown",
                MainMuscleGroupType = MuscleGroupType.Glutes,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Glutes,
                    MuscleGroupType.Quads
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Step Up",
                MainMuscleGroupType = MuscleGroupType.Quads,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Quads,
                    MuscleGroupType.Glutes
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
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
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Incline Dumbbell Row",
                MainMuscleGroupType = MuscleGroupType.Back,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Back,
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.InclineBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Chin Up",
                MainMuscleGroupType = MuscleGroupType.Back,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Back,
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.ChinUpBar
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Trap-Bar Deadlift",
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
                    LiftingEquipmentType.TrapBar
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Rack Pull",
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
                    LiftingEquipmentType.PowerRack,
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Back Extension",
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
                ExerciseName = "Yates Row",
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
                ExerciseName = "Pendlay Row",
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
                ExerciseName = "Pull Up",
                MainMuscleGroupType = MuscleGroupType.Back,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Back,
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.PullupBar
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Lat Pulldown",
                MainMuscleGroupType = MuscleGroupType.Back,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Back,
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Cable
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Close-Grip Pulldown",
                MainMuscleGroupType = MuscleGroupType.Back,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Back,
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Cable
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Decline Bench Dumbbell Pullover",
                MainMuscleGroupType = MuscleGroupType.Back,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Back,
                    MuscleGroupType.Chest
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.DeclineBench,
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Pullover",
                MainMuscleGroupType = MuscleGroupType.Back,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Back,
                    MuscleGroupType.Chest
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.FlatBench,
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Inverted Row",
                MainMuscleGroupType = MuscleGroupType.Back,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Back,
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.SmithMachine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Barbell T-Bar Row",
                MainMuscleGroupType = MuscleGroupType.Back,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Back,
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Seated Cable Row",
                MainMuscleGroupType = MuscleGroupType.Back,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Back,
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Cable
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Face Pull",
                MainMuscleGroupType = MuscleGroupType.RearDelts,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.RearDelts
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Cable
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Barbell Overhead Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Standing Dumbbell Flye",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Upright Row",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Upright Row",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "High Pull",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell High Pull",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Front Raise",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Kettlebell Front Raise",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Kettlebell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Front Raise",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Lateral Raise",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Kettlebell Lateral Raise",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Kettlebell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Band Lateral Raise",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.ResistanceBand
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Band Bent-Over Lateral Raise",
                MainMuscleGroupType = MuscleGroupType.RearDelts,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.RearDelts
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.ResistanceBand
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Bent-Over Lateral Raise",
                MainMuscleGroupType = MuscleGroupType.RearDelts,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.RearDelts
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Handstand Push Up",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Neutral Grip Standing Overhead Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Bent-Over Reverse Flye",
                MainMuscleGroupType = MuscleGroupType.RearDelts,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.RearDelts
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Military Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps,
                    MuscleGroupType.Core
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Push Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps,
                    MuscleGroupType.Core
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Seated Dumbbell Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.SeatedBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Seated Overhead Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell,
                    LiftingEquipmentType.SeatedBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Standing Dumbbell Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Standing Kettlebell Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Kettlebell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Standing Kettlebell Arnold Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Kettlebell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Standing Dumbbell Arnold Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Seated Dumbbell Arnold Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.SeatedBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Seated Kettlebell Arnold Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Kettlebell,
                    LiftingEquipmentType.SeatedBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Seated Smith-Machine Shoulder Press",
                MainMuscleGroupType = MuscleGroupType.Shoulders,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.SmithMachine,
                    LiftingEquipmentType.SeatedBench
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

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Incline Bench Press",
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
                    LiftingEquipmentType.InclineBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Bench Press",
                MainMuscleGroupType = MuscleGroupType.Chest,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Chest,
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Incline Dumbbell Bench Press",
                MainMuscleGroupType = MuscleGroupType.Chest,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Chest,
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.InclineBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Decline Bench Press",
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
                    LiftingEquipmentType.DeclineBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Decline Dumbbell Bench Press",
                MainMuscleGroupType = MuscleGroupType.Chest,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Chest,
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.DeclineBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Incline Dumbbell Flye",
                MainMuscleGroupType = MuscleGroupType.Chest,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Chest
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.InclineBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Flat Dumbbell Flye",
                MainMuscleGroupType = MuscleGroupType.Chest,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Chest
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Decline Dumbbell Flye",
                MainMuscleGroupType = MuscleGroupType.Chest,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Chest
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.DeclineBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Standing Cable Crossover",
                MainMuscleGroupType = MuscleGroupType.Chest,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Chest
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Cable
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dips",
                MainMuscleGroupType = MuscleGroupType.Chest,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Chest,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Bench Dips",
                MainMuscleGroupType = MuscleGroupType.Triceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Push Up",
                MainMuscleGroupType = MuscleGroupType.Chest,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Chest,
                    MuscleGroupType.Shoulders,
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Diamond Push Up",
                MainMuscleGroupType = MuscleGroupType.Triceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Triceps,
                    MuscleGroupType.Chest,
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dive Bomber Push Up",
                MainMuscleGroupType = MuscleGroupType.Chest,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Chest,
                    MuscleGroupType.Triceps,
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Close-Grip Bench Press",
                MainMuscleGroupType = MuscleGroupType.Triceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Triceps,
                    MuscleGroupType.Chest,
                    MuscleGroupType.Shoulders
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell,
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Overhead Triceps Extension",
                MainMuscleGroupType = MuscleGroupType.Triceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.SeatedBench,
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Cable Overhead Triceps Extension",
                MainMuscleGroupType = MuscleGroupType.Triceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Cable
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Skullcrusher",
                MainMuscleGroupType = MuscleGroupType.Triceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
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
                ExerciseName = "EZ Bar Skullcrusher",
                MainMuscleGroupType = MuscleGroupType.Triceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.EZBar,
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Rope Tricep Pushdown",
                MainMuscleGroupType = MuscleGroupType.Triceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Cable
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Cable Pushdown",
                MainMuscleGroupType = MuscleGroupType.Triceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Triceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Cable
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Incline Bicep Curl",
                MainMuscleGroupType = MuscleGroupType.Biceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.InclineBench,
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Hammer Curl",
                MainMuscleGroupType = MuscleGroupType.Biceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Biceps,
                    MuscleGroupType.Forearms
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Concentration Curl",
                MainMuscleGroupType = MuscleGroupType.Biceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "EZ Bar Curl",
                MainMuscleGroupType = MuscleGroupType.Biceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.EZBar
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Barbell Curl",
                MainMuscleGroupType = MuscleGroupType.Biceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Spider Curl",
                MainMuscleGroupType = MuscleGroupType.Biceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell,
                    LiftingEquipmentType.InclineBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "EZ Bar Spider Curl",
                MainMuscleGroupType = MuscleGroupType.Biceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.EZBar,
                    LiftingEquipmentType.InclineBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Preacher Curl",
                MainMuscleGroupType = MuscleGroupType.Biceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.EZBar,
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Preacher Curl",
                MainMuscleGroupType = MuscleGroupType.Biceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell,
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Curl",
                MainMuscleGroupType = MuscleGroupType.Biceps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Biceps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Barbell Shrug",
                MainMuscleGroupType = MuscleGroupType.Traps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
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
                ExerciseName = "Dumbbell Shrug",
                MainMuscleGroupType = MuscleGroupType.Traps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Traps,
                    MuscleGroupType.Forearms
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Smith Machine Shrug",
                MainMuscleGroupType = MuscleGroupType.Traps,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Traps,
                    MuscleGroupType.Forearms
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.SmithMachine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Farmer's Walk",
                MainMuscleGroupType = MuscleGroupType.Forearms,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Forearms,
                    MuscleGroupType.Traps
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Reverse Barbell Curl",
                MainMuscleGroupType = MuscleGroupType.Forearms,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Forearms
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Barbell Wrist Curl",
                MainMuscleGroupType = MuscleGroupType.Forearms,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Forearms
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Wrist Curl",
                MainMuscleGroupType = MuscleGroupType.Forearms,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Forearms
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Reverse Barbell Wrist Curl",
                MainMuscleGroupType = MuscleGroupType.Forearms,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Forearms
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Reverse Dumbbell Wrist Curl",
                MainMuscleGroupType = MuscleGroupType.Forearms,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Forearms
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Leg Press Calf Raise",
                MainMuscleGroupType = MuscleGroupType.Calves,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Calves
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Barbell Seated Calf Raise",
                MainMuscleGroupType = MuscleGroupType.Calves,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Calves
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Barbell,
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Donkey Calf Raise",
                MainMuscleGroupType = MuscleGroupType.Calves,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Calves
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Partner Donkey Calf Raise",
                MainMuscleGroupType = MuscleGroupType.Calves,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Calves
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.WorkoutPartner
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Seated Calf Raise",
                MainMuscleGroupType = MuscleGroupType.Calves,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Calves
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Standing Calf Raise",
                MainMuscleGroupType = MuscleGroupType.Calves,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Calves
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dumbbell Standing Calf Raise",
                MainMuscleGroupType = MuscleGroupType.Calves,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Calves
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Dumbbell
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Decline Sit Up",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.DeclineBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Hanging Leg Raise",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.PullupBar
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Hanging Leg Lift",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Machine
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Lying Leg Raise",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Seated Leg Raise",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Decline Russian Twist",
                MainMuscleGroupType = MuscleGroupType.Obliques,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Obliques,
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.DeclineBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Russian Twist",
                MainMuscleGroupType = MuscleGroupType.Obliques,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Obliques,
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Crunch",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Sit Up",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Ab Wheel Rollout",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.AbWheel
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Bicycle Crunch",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "V Up",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Mountain Climber",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Plank",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs,
                    MuscleGroupType.Core
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Dragon Flag",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.FlatBench
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Windshield Wiper",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs,
                    MuscleGroupType.Core
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.Bodyweight
                }
            });

            exerciseSeedData.Add(new ExerciseSeedData()
            {
                ExerciseName = "Hanging Windshield Wiper",
                MainMuscleGroupType = MuscleGroupType.Abs,
                MuscleGroupTypes = new List<MuscleGroupType>()
                {
                    MuscleGroupType.Abs,
                    MuscleGroupType.Core
                },
                LiftingEquipmentTypes = new List<LiftingEquipmentType>()
                {
                    LiftingEquipmentType.PullupBar
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
