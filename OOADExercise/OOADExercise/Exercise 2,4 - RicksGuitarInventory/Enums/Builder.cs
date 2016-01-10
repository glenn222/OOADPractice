using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADExercise.Exercise_2.Enums
{
    public enum Builder
    {
        FENDER, MARTIN, GIBSON, COLLINGS, OLSON, RYAN, PRS, ANY
    }

    public class BuilderExtensionMethods
    {
        public static string toString(Builder builder)
        {
            switch (builder)
            {
                case Builder.FENDER:
                    return "Fender";
                case Builder.MARTIN:
                    return "Martin";
                case Builder.GIBSON:
                    return "Gibson";
                case Builder.COLLINGS:
                    return "Collings";
                case Builder.OLSON:
                    return "Olson";
                case Builder.RYAN:
                    return "Ryan";
                case Builder.PRS:
                    return "Prs";
                case Builder.ANY:
                    return "Any";
                default:
                    return null;
            }
        }
    }
}
