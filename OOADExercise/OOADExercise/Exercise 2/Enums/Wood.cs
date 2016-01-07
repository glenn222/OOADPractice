using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADExercise.Exercise_2.Enums
{
    public enum Wood
    {
        INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOD, MAHOGANY, MAPLE, COCOBOLO, CEDAR, ADIRONDACK, ALDER, SITKA
    }

    public class WoodExtensionMethods
    {
        public static string toString(Wood wood) {
            switch (wood)
            {
                case Wood.INDIAN_ROSEWOOD:
                    return "Indian Rosewood";
                case Wood.BRAZILIAN_ROSEWOOD:
                    return "Brazilian Rosewood";
                case Wood.MAHOGANY:
                    return "Mahogany";
                case Wood.MAPLE:
                    return "Maple";
                case Wood.COCOBOLO:
                    return "Cocobolo";
                case Wood.CEDAR:
                    return "Cedar";
                case Wood.ADIRONDACK:
                    return "Adirondack";
                case Wood.ALDER:
                    return "Alder";
                case Wood.SITKA:
                    return "Sitka";
                default:
                    return null;
            }
        }
    }
}
