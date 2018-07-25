using FitnessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Data
{
    public class ExerciseSeedData
    {
        public string ExerciseName { get; set; }
        public List<MuscleGroupType> MuscleGroupTypes { get; set; }
        public List<LiftingEquipmentType> LiftingEquipmentTypes { get; set; }
    }
}
