using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Entities
{
    public class ExerciseLiftingEquipment
    {
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

        public int LiftingEquipmentId { get; set; }
        public LiftingEquipment LiftingEquipment { get; set; }
    }
}
