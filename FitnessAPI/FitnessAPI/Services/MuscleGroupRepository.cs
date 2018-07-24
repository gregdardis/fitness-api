using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessAPI.Data;
using FitnessAPI.Entities;

namespace FitnessAPI.Services
{
    public class MuscleGroupRepository : IMuscleGroupRepository
    {
        private FitnessApiDbContext _context;

        public MuscleGroupRepository(FitnessApiDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MuscleGroup> GetMuscleGroups()
        {
            return _context.MuscleGroups.ToList();
        }
    }
}
