using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADExercise.Exercise_2.Enums
{
    public enum InstrumentType
    {
        GUITAR, BANJO, DOBRO, FIDDLE, BASS, MANDOLIN
    }
    public class InstrumentTypeExtensionMethods
    {
        public static string toString(InstrumentType type)
        {
            switch (type)
            {
                case InstrumentType.GUITAR:
                    return "Guitar";
                case InstrumentType.BANJO:
                    return "Banjo";
                case InstrumentType.DOBRO:
                    return "Dobro";
                case InstrumentType.FIDDLE:
                    return "Fiddle";
                case InstrumentType.BASS:
                    return "Bass";
                case InstrumentType.MANDOLIN:
                    return "Mandolin";
                default:
                    return "Unspecified";
            }
        }
    }
}
