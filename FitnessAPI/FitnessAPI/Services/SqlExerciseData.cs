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
            return _context.Exercises.FirstOrDefault(exercise => exercise.Id == id);
        }

        // look into using IQueryable instead
        public IEnumerable<Exercise> GetAll()
        {
            return _context.Exercises.OrderBy(exercise => exercise.Name);
        }
    }
}
