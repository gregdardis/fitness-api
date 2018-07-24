﻿using System.Collections.Generic;
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

        public ICollection<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; } = new List<ExerciseMuscleGroup>();
        //public ICollection<LiftingEquipment> LiftingEquipment { get; set; } = new List<LiftingEquipment>();

        public string VideoURL { get; set; }
    }
}