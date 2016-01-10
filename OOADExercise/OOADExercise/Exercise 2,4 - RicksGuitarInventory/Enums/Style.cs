using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADExercise.Exercise_2.Enums
{
    public enum Style
    {
        A, F
    }

    public class StyleExtensionMethods
    {
        public static string toString(Style style)
        {
            switch (style)
            {
                case Style.A:
                    return "A";
                case Style.F:
                    return "F";
                default:
                    return null;
            }
        }
    }
}
