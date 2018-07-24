using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public Exercise GetExercise(int exerciseId)
        {
            return _context.Exercises
                .Where(e => e.ExerciseId == exerciseId).FirstOrDefault();
        }

        public IEnumerable<Exercise> GetExercises()
        {
            return _context.Exercises.OrderBy(e => e.Name).ToList();
        }

        public ICollection<MuscleGroupType> GetMuscleGroupsForExercise(int exerciseId)
        {
            var exerciseMuscleGroups = _context.ExerciseMuscleGroups
                .Where(e => e.ExerciseId == exerciseId).ToList();

            var muscleGroupTypes = new List<MuscleGroupType>();

            foreach (var e in exerciseMuscleGroups)
            {
                var muscleGroupId = e.MuscleGroupId;
                muscleGroupTypes.Add(_context.MuscleGroups.Where(m => m.MuscleGroupId == muscleGroupId).FirstOrDefault().MuscleGroupType);
            }

            return muscleGroupTypes;
        }
    }
}
