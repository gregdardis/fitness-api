using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private IExerciseData _exerciseData;

        public ExercisesController(IExerciseData exerciseData)
        {
            _exerciseData = exerciseData;
        }

        // GET api/exercises
        [HttpGet]
        public IEnumerable<Exercise> Index()
        {
            return _exerciseData.GetAll();
        } 
    }
}