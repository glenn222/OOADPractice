using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADExercise.Exercise_3__DougsDogDoor
{
    public class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void Recognize(String sound)
        {
            Console.WriteLine("BarkRecognizer: Heard a '{0}'", sound);
            if (sound.Equals("bark"))
                door.Open();
        }
    }
}
