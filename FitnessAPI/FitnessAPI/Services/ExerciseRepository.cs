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

        public Exercise GetExercise(int exerciseId)
        {
            return _context.Exercises
                .Where(e => e.ExerciseId == exerciseId)
                .Include(ex => ex.ExerciseMuscleGroups)
                    .ThenInclude(emg => emg.MuscleGroup)
                .FirstOrDefault();
        }

        public IEnumerable<Exercise> GetExercises()
        {
            return _context.Exercises.OrderBy(e => e.Name).ToList();
        }
    }
}
