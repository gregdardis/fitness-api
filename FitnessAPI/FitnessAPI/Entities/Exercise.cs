using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessAPI.Entities
{
    public class Exercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExerciseId { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; }
        
        //public MuscleGroup MainMuscleGroup { get; set; }

        public IEnumerable<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; } = new List<ExerciseMuscleGroup>();
        public IEnumerable<ExerciseLiftingEquipment> ExerciseLiftingEquipment { get; set; } = new List<ExerciseLiftingEquipment>();

        public string VideoURL { get; set; }
    }
}
