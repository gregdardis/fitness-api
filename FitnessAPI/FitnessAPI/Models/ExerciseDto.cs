using FitnessAPI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Models
{
    public class ExerciseDto
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        //public MuscleGroup MainMuscleGroup { get; set; }
        
        public ICollection<MuscleGroupType> MuscleGroups { get; set; } = new List<MuscleGroupType>();
        //public ICollection<LiftingEquipment> LiftingEquipment { get; set; } = new List<LiftingEquipment>();
        
        public string VideoURL { get; set; }
    }
}
