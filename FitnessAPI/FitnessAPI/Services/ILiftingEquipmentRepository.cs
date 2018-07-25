using FitnessAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Services
{
    public interface ILiftingEquipmentRepository
    {
        IEnumerable<LiftingEquipment> GetLiftingEquipment();
    }
}
