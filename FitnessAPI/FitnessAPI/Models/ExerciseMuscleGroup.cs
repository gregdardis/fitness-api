using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Models
{
    public class ExerciseMuscleGroup
    {
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

        public int MuscleGroupId { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
    }
}
