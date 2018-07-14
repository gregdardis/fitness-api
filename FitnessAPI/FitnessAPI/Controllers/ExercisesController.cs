using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        // GET api/exercises
        [HttpGet]
        public IActionResult Index()
        {
            //return new string[] { "exercise1", "exercise2", "exercise3" };
            return new ObjectResult("test");
        }
    }
}