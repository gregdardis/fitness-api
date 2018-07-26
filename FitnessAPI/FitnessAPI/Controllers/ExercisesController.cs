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

            return Ok(exercise);
        }

        [HttpGet("mainmusclegroup/{muscleGroup}")]
        public IActionResult GetExercisesWithMainMuscleGroup(string muscleGroup)
        {
            var exerciseEntities = _exerciseRepository.GetExercisesWithMainMuscleGroup(muscleGroup);

            if (exerciseEntities == null)
            {
                return NotFound();
            }

            var exercises = Mapper.Map<IEnumerable<ExerciseDto>>(exerciseEntities);

            return Ok(exercises);
        }

        [HttpGet("containsmusclegroup/{muscleGroup}")]
        public IActionResult GetExercisesContainingMuscleGroup(string muscleGroup)
        {
            var exerciseEntities = _exerciseRepository.GetExercisesContainingMuscleGroup(muscleGroup);

            if (exerciseEntities == null)
            {
                return NotFound();
            }

            var exercises = Mapper.Map<IEnumerable<ExerciseDto>>(exerciseEntities);

            return Ok(exercises);
        }

        [HttpGet("{exerciseName}")]
        public IActionResult GetExerciseByName(string exerciseName)
        {
            var exerciseEntity = _exerciseRepository.GetExerciseByName(exerciseName);

            if (exerciseEntity == null)
            {
                return NotFound();
            }

            var exercise = Mapper.Map<ExerciseDto>(exerciseEntity);

            return Ok(exercise);
        }
    }
}