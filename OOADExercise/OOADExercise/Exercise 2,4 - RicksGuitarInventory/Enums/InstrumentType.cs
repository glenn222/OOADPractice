using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADExercise.Exercise_2.Enums
{
    public enum InstrumentType
    {
        ACOUSTIC, ELECTRIC
    }

    public class TypeExtensionMethods
    {
        public static string toString(InstrumentType type)
        {
            switch (type)
            {
                case InstrumentType.ACOUSTIC:
                    return "Acoustic";
                case InstrumentType.ELECTRIC:
                    return "Electric";
                default:
                    return null;
            }
        }
    }
}
