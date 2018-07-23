using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FitnessAPI.Models;
using FitnessAPI.Services;
using Microsoft.AspNetCore.Http;
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
            var results = Mapper.Map<IEnumerable<ExerciseWithoutMuscleGroupsOrEquipmentDto>>(exerciseEntities);

            return Ok(results);
        } 
    }
}