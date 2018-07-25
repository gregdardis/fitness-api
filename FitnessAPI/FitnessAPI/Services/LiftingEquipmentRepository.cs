using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessAPI.Data;
using FitnessAPI.Entities;

namespace FitnessAPI.Services
{
    public class LiftingEquipmentRepository : ILiftingEquipmentRepository
    {
        private FitnessApiDbContext _context;

        public LiftingEquipmentRepository(FitnessApiDbContext context)
        {
            _context = context;
        }

        public IEnumerable<LiftingEquipment> GetLiftingEquipment()
        {
            return _context.LiftingEquipment.ToList();
        }
    }
}
