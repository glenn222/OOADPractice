using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADExercise.Exercise_2.Enums
{
    public enum GuitarType
    {
        ACOUSTIC, ELECTRIC
    }

    public class TypeExtensionMethods
    {
        public static string toString(GuitarType type)
        {
            switch (type)
            {
                case GuitarType.ACOUSTIC:
                    return "Acoustic";
                case GuitarType.ELECTRIC:
                    return "Electric";
                default:
                    return null;
            }
        }
    }
}
