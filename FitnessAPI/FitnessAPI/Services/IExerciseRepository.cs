using FitnessAPI.Entities;
using FitnessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Services
{
    public interface IExerciseRepository
    {
        IEnumerable<Exercise> GetExercises();
        Exercise GetExercise(int exerciseId);
        // TODO: investigate whether this should be in a MuscleGroupsRepository
        // or stay here
        ICollection<MuscleGroupType> GetMuscleGroupsForExercise(int exerciseId);
        //    // get exercises with main muscle group "__"
        //    // get exercises by contains muscle group
        //    // get exercises by exact name
        //    // get exercises by name contains this string
        //    // get exercises by equipment
        //    // get exercises with video
        //    // need to be able to combine multiple of these using a query string
    }
}
