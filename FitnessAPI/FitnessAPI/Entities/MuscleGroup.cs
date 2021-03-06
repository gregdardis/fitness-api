﻿using FitnessAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessAPI.Entities
{
    public class MuscleGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MuscleGroupId { get; set; }
        
        public MuscleGroupType MuscleGroupType { get; set; }

        public IEnumerable<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; } = new List<ExerciseMuscleGroup>();
    }
}
