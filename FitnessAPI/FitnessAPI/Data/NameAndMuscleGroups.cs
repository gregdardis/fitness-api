using FitnessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Data
{
    public class NameAndMuscleGroups
    {
        public string ExerciseName { get; set; }
        public List<MuscleGroupType> MuscleGroupTypes { get; set; }
    }
}
