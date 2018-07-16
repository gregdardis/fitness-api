using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public MuscleGroup MainMuscleGroup { get; set; }
        public MuscleGroup[] MuscleGroups { get; set; }
        public LiftingEquipment[] Equipment { get; set; }
        public string VideoURL { get; set; }
    }
}
