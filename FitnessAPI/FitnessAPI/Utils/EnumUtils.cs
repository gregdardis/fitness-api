using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAPI.Utils
{
    public static class EnumUtils
    {
        public static T? Parse<T>(string input) where T : struct
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("Generic Type 'T' must be an Enum.");
            }
            if (!string.IsNullOrEmpty(input))
            {
                if (Enum.GetNames(typeof(T)).Any(
                    e => e.Trim().ToUpperInvariant() == input.Trim().ToUpperInvariant()))
                {
                    return (T)Enum.Parse(typeof(T), input, true);
                }
            }
            return null;
        }
    }
}
