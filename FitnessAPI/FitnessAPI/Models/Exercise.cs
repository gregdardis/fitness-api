using FitnessAPI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Models
{
    public class Exercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExerciseId { get; set; }

        //[Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //[Required]
        //public MuscleGroup MainMuscleGroup { get; set; }
        
        public ICollection<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; } = new List<ExerciseMuscleGroup>();
        //public ICollection<LiftingEquipment> LiftingEquipment { get; set; } = new List<LiftingEquipment>();
        
        public string VideoURL { get; set; }
    }
}
