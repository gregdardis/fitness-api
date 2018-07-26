using FitnessAPI.Entities;
using FitnessAPI.Models;
using System.Collections.Generic;

namespace FitnessAPI.Services
{
    public interface IExerciseRepository
    {
        IEnumerable<Exercise> GetExercises();
        Exercise GetExercise(int exerciseId);
        IEnumerable<Exercise> GetExercisesWithMainMuscleGroup(string muscleGroup);
        // get exercises by contains muscle group
        IEnumerable<Exercise> GetExercisesContainingMuscleGroup(string muscleGroup);
        // get exercises by exact name
        // get exercises by name contains this string
        // get exercises by equipment
        // get exercises with video
        // need to be able to combine multiple of these using a query string
    }
}
