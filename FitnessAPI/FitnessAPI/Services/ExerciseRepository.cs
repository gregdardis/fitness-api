﻿using System.Collections.Generic;
using System.Linq;
using FitnessAPI.Data;
using FitnessAPI.Entities;
using FitnessAPI.Models;

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
                .Where(mg => mg.ExerciseId == exerciseId)
                .Join(_context.MuscleGroups,
                      e => e.MuscleGroupId,
                      m => m.MuscleGroupId,
                      (e, m) => new { e.ExerciseId, m.MuscleGroupType })
                .Select(mg => mg.MuscleGroupType);

            return exerciseMuscleGroups.ToList();
        }
    }
}