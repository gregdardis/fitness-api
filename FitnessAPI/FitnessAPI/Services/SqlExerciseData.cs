using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessAPI.Data;
using FitnessAPI.Models;

namespace FitnessAPI.Services
{
    public class SqlExerciseData : IExerciseData
    {
        private FitnessApiDbContext _context;

        public SqlExerciseData(FitnessApiDbContext context)
        {
            _context = context;
        }

        public Exercise Get(int id)
        {
            return _context.Exercises.FirstOrDefault(exercise => exercise.ExerciseId == id);
        }

        // look into using IQueryable instead
        public IEnumerable<Exercise> GetAll()
        {
            // Steps:
            // 1. Get all exercises from _context
            // 2. Go through each exercise
            // 3. Look at it's exerciseId
            // 4. Find all MuscleGroups with that ExerciseId from MuscleGroups in _context
            // 5. Assign those MuscleGroups to the ExerciseId
            // 6. Return that IEnumerable of exercises

            return _context.Exercises.OrderBy(exercise => exercise.Name);
        }
    }
}
