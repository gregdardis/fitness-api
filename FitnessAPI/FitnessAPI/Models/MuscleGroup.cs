using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Models
{
    public class MuscleGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MuscleGroupId { get; set; }
        
        //[Required]
        public MuscleGroupType MuscleGroupType { get; set; }

        public ICollection<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; } = new List<ExerciseMuscleGroup>();
    }
    public enum MuscleGroupType
    {
        Abs,
        Back,
        Biceps,
        Calves,
        Chest,
        Forearms,
        Glutes,
        Hamstrings,
        LowerBack,
        Quads,
        Shoulders,
        Traps,
        Triceps
    }
}
