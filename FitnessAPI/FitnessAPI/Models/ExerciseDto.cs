using System.Collections.Generic;
namespace FitnessAPI.Models
{
    public class ExerciseDto
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        //public MuscleGroup MainMuscleGroup { get; set; }
        
        public IEnumerable<string> MuscleGroups { get; set; } = new List<string>();
        //public IEnumerable<LiftingEquipment> LiftingEquipment { get; set; } = new List<LiftingEquipment>();

        public string VideoURL { get; set; }
    }
}
