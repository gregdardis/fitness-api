using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessAPI.Models;

namespace FitnessAPI.Services
{
    public class InMemoryExerciseData : IExerciseData
    {
        private List<Exercise> _exercises;

        public InMemoryExerciseData()
        {
            _exercises = new List<Exercise>
            {
                new Exercise {
                    Id = 1,
                    Name = "Bench Press",
                    MainMuscleGroup = MuscleGroup.Chest,
                    MuscleGroups = new MuscleGroup[] { MuscleGroup.Chest, MuscleGroup.Shoulders, MuscleGroup.Triceps },
                    Equipment = new LiftingEquipment[] { LiftingEquipment.Barbell, LiftingEquipment.FlatBench }
                },
                new Exercise {
                    Id = 2,
                    Name = "High Bar Squat",
                    MainMuscleGroup = MuscleGroup.Quads,
                    MuscleGroups = new MuscleGroup[] { MuscleGroup.Quads, MuscleGroup.Hamstrings, MuscleGroup.Glutes },
                    Equipment = new LiftingEquipment[] { LiftingEquipment.Barbell, LiftingEquipment.PowerRack }
                },
                new Exercise {
                    Id = 3,
                    Name = "Chin Up",
                    MainMuscleGroup = MuscleGroup.Back,
                    MuscleGroups = new MuscleGroup[] { MuscleGroup.Back, MuscleGroup.Biceps },
                    Equipment = new LiftingEquipment[] { LiftingEquipment.ChinUpBar }
                },
                new Exercise {
                    Id = 4,
                    Name = "Barbell Overhead Press",
                    MainMuscleGroup = MuscleGroup.Shoulders,
                    MuscleGroups = new MuscleGroup[] { MuscleGroup.Shoulders, MuscleGroup.Triceps },
                    Equipment = new LiftingEquipment[] { LiftingEquipment.Barbell, LiftingEquipment.PowerRack }
                }
            };
        }

        // todo: add dbcontext and database support with EF
        // figure out if going from database => model => json is the fastest
        // way or if we can skip model step and go straight to json

        public Exercise Get(int id)
        {
            return _exercises.FirstOrDefault(exercise => exercise.Id == id);
        }

        public IEnumerable<Exercise> GetAll()
        {
            return _exercises.OrderBy(exercise => exercise.Name);
        }
    }
}
