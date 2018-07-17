using FitnessAPI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public MuscleGroup MainMuscleGroup { get; set; }

        //public string MuscleGroupsInternalData { get; set; }
        //[NotMapped]
        //public MuscleGroup[] MuscleGroups
        //{
        //    get
        //    {
        //        // returns an array of enums
        //        string[] muscleGroupsStr = MuscleGroupsInternalData.Split(';');
        //        MuscleGroup[] muscleGroups = new MuscleGroup[muscleGroupsStr.Length];
        //        for (int i = 0; i < muscleGroupsStr.Length; i++)
        //        {
        //            Enum.TryParse(muscleGroupsStr[i], out MuscleGroup muscleGroup);
        //            muscleGroups[i] = muscleGroup;
        //        }
        //        return muscleGroups;
        //    }
        //    set
        //    {
        //        // sets MuscleGroupsInternalData to strings separated by ';'
        //        MuscleGroups = value;
        //        this.MuscleGroupsInternalData = String.Join(';', MuscleGroups.Select(mg => mg.ToString()).ToArray());
        //    }
        //}
        // TODO: figure out how to get muscle groups on the json response
        // for GET all exercises request. currently null
        public ICollection<MuscleGroup> MuscleGroups { get; set; }

        public string EquipmentInternalData { get; set; }
        [NotMapped]
        public LiftingEquipment[] Equipment
        {
            get
            {
                // returns an array of enums
                string[] equipmentStr = EquipmentInternalData.Split(';');
                LiftingEquipment[] equipment = new LiftingEquipment[equipmentStr.Length];
                for (int i = 0; i < equipmentStr.Length; i++)
                {
                    Enum.TryParse(equipmentStr[i], out LiftingEquipment liftingEquipment);
                    equipment[i] = liftingEquipment;
                }
                return equipment;
            }
            set
            {
                // sets EquipmentInternalData to strings separated by ';'
                Equipment = value;
                this.EquipmentInternalData = String.Join(';', Equipment.Select(e => e.ToString()).ToArray());
            }
        }


        public string VideoURL { get; set; }
    }
}
