using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADExercise.Exercise_3__DougsDogDoor
{
    public class Bark
    {
        private string sound;

        public Bark(string sound)
        {
            this.sound = sound;
        }

        public bool equals (object bark)
        {
            if (bark.GetType().Equals(new Bark(getSound())))
            {
                Bark otherBark = (Bark)bark;
                if (sound.Equals(otherBark.sound))
                {
                    Console.WriteLine("Barks are the same");
                    return true;
                }
            }
            return false;
        }

        public string getSound()
        {
            return sound;
        }
    }
}
