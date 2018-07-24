using AutoMapper;
using FitnessAPI.Models;
using FitnessAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FitnessAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuscleGroupsController : ControllerBase
    {
        private IMuscleGroupRepository _muscleGroupRepository;

        public MuscleGroupsController(IMuscleGroupRepository muscleGroupRepository)
        {
            _muscleGroupRepository = muscleGroupRepository;
        }

        [HttpGet]
        public IActionResult GetMuscleGroupTypes()
        {
            var muscleGroups = _muscleGroupRepository.GetMuscleGroups();
            //var muscleGroupTypes = Mapper.Map<MuscleGroupType>(muscleGroups);
            var muscleGroupTypes = muscleGroups.Select(m => m.MuscleGroupType.ToString());

            return Ok(muscleGroupTypes);
        }
    }
}
