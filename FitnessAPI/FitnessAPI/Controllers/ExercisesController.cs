using System.Collections.Generic;
using AutoMapper;
using FitnessAPI.Models;
using FitnessAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        private IExerciseRepository _exerciseRepository;

        public ExercisesController(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }
        
        [HttpGet]
        public IActionResult GetExercisesNoMuscleGroupsOrEquipment()
        {
            var exerciseEntities = _exerciseRepository.GetExercises();
            var exercises = Mapper.Map<IEnumerable<ExerciseWithoutMuscleGroupsOrEquipmentDto>>(exerciseEntities);

            return Ok(exercises);
        }

        [HttpGet("{id}")]
        public IActionResult GetExerciseById(int id)
        {
            var exerciseEntity = _exerciseRepository.GetExercise(id);

            if (exerciseEntity == null)
            {
                return NotFound();
            }

            var exerciseMuscleGroups = exerciseEntity.ExerciseMuscleGroups;

            var exercise = Mapper.Map<ExerciseDto>(exerciseEntity);

            var iter = exerciseMuscleGroups.GetEnumerator();
            bool hasNext = iter.MoveNext();
            while (hasNext)
            {
                exercise.MuscleGroups.Add(iter.Current.MuscleGroup.MuscleGroupType.ToString());
                hasNext = iter.MoveNext();
            }

            return Ok(exercise);
        }
    }
}