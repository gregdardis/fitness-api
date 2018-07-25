using AutoMapper;
using FitnessAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiftingEquipmentController : ControllerBase
    {
        private ILiftingEquipmentRepository _liftingEquipmentRepository;

        public LiftingEquipmentController(ILiftingEquipmentRepository liftingEquipmentRepository)
        {
            _liftingEquipmentRepository = liftingEquipmentRepository;
        }

        [HttpGet]
        public IActionResult GetLiftingEquipmentTypes()
        {
            var liftingEquipment = _liftingEquipmentRepository.GetLiftingEquipment();
            var liftingEquipmentTypes = Mapper.Map<IEnumerable<string>>(liftingEquipment);

            return Ok(liftingEquipmentTypes);
        }
    }
}
