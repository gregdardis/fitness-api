using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Models
{
    public class ExerciseWithoutMuscleGroupsOrEquipmentDto
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public MuscleGroupType MainMuscleGroupType { get; set; }

        public string VideoURL { get; set; }
    }
}
