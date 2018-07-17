using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Models
{
    public class MuscleGroup
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public MuscleGroupType MuscleGroupType { get; set; }
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
