using System.Collections.Generic;
using System.Linq;
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

            var exercise = Mapper.Map<ExerciseDto>(exerciseEntity);

            exercise.MuscleGroups = exerciseEntity.ExerciseMuscleGroups.Select(
                emg => emg.MuscleGroup.MuscleGroupType.ToString());
            // figure out how to do this with automapper ^^

            return Ok(exercise);
        }
    }
}