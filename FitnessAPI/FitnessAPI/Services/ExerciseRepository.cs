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
                .Join(_context.MuscleGroups, e => e.MuscleGroupId,
                m => m.MuscleGroupId, (e, m) => new { e, m })
                .Where(mg => mg.e.ExerciseId == exerciseId)
                .Select(mg => mg.m.MuscleGroupType);

            return exerciseMuscleGroups.ToList();
        }
    }
}
