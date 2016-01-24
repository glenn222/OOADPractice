using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADExercise.Exercise_2.Enums
{
    public enum PlayType
    {
        ACOUSTIC, ELECTRIC
    }

    public class PlayTypeExtensionMethods
    {
        public static string toString(PlayType type)
        {
            switch (type)
            {
                case PlayType.ACOUSTIC:
                    return "Acoustic";
                case PlayType.ELECTRIC:
                    return "Electric";
                default:
                    return null;
            }
        }
    }
}
