using FitnessAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessAPI.Entities
{
    public class LiftingEquipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LiftingEquipmentId { get; set; }

        public LiftingEquipmentType LiftingEquipmentType { get; set; }

        public IEnumerable<ExerciseLiftingEquipment> ExerciseLiftingEquipment { get; set; } = new List<ExerciseLiftingEquipment>();
    }
}
