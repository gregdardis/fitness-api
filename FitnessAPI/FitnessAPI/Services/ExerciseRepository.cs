using System.Collections.Generic;
using System.Linq;
using FitnessAPI.Data;
using FitnessAPI.Entities;
using FitnessAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessAPI.Services
{
    public class ExerciseRepository : IExerciseRepository
    {
        private FitnessApiDbContext _context;

        public ExerciseRepository(FitnessApiDbContext context) 
        {
            _context = context;
        }

        // TODO: go through and extract method to include muscle groups and lifting
        // equipment into every exercise
        public Exercise GetExercise(int exerciseId)
        {
            return _context.Exercises
                .Where(e => e.ExerciseId == exerciseId)
                .Include(ex => ex.ExerciseMuscleGroups)
                    .ThenInclude(emg => emg.MuscleGroup)
                .Include(e => e.ExerciseLiftingEquipment)
                    .ThenInclude(ele => ele.LiftingEquipment)
                .FirstOrDefault();
        }

        public Exercise GetExerciseByName(string exerciseName)
        {
            return _context.Exercises
                .Where(e => e.Name.ToLower() == exerciseName.ToLower())
                .Include(ex => ex.ExerciseMuscleGroups)
                    .ThenInclude(emg => emg.MuscleGroup)
                .Include(e => e.ExerciseLiftingEquipment)
                    .ThenInclude(ele => ele.LiftingEquipment)
                .SingleOrDefault();
        }

        public IEnumerable<Exercise> GetExercises()
        {
            return _context.Exercises.OrderBy(e => e.Name).ToList();
        }

        public IEnumerable<Exercise> GetExercisesContainingMuscleGroup(string muscleGroup)
        {
            return _context.Exercises
                .Where(e => e.ExerciseMuscleGroups.Any(m => m.MuscleGroup
                    .MuscleGroupType.ToString().ToLower() == muscleGroup.ToLower()))
                    .Include(ex => ex.ExerciseMuscleGroups)
                        .ThenInclude(emg => emg.MuscleGroup)
                    .Include(ex => ex.ExerciseLiftingEquipment)
                        .ThenInclude(ele => ele.LiftingEquipment)
                    .ToList();
        }

        public IEnumerable<Exercise> GetExercisesWithMainMuscleGroup(string muscleGroup)
        {
            return _context.Exercises
                .Where(e => e.MainMuscleGroupType.ToString().ToLower() == muscleGroup.ToLower())
                .Include(ex => ex.ExerciseMuscleGroups)
                    .ThenInclude(emg => emg.MuscleGroup)
                .Include(e => e.ExerciseLiftingEquipment)
                    .ThenInclude(ele => ele.LiftingEquipment)
                .ToList(); ;
        }
    }
}
