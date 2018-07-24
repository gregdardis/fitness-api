using FitnessAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Models
{
    public class LiftingEquipment
    {
        public int Id { get; set; }
        public Equipment Equipment { get; set; }
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
    public enum Equipment
    {
        Barbell,
        Bodyweight,
        Cable,
        ChinUpBar,
        DeclineBench,
        DipBar,
        Dumbbell,
        EZBar,
        FlatBench,
        HammerGripPullupBar,
        InclineBench,
        Kettlebell,
        Machine,
        MedicineBall,
        PowerRack,
        PullupBar,
        SmithMachine
    }
}
