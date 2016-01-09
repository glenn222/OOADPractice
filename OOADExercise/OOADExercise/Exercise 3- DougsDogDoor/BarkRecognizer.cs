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

        public void Recognize(Bark bark)
        {
            // The recognize method ask the owner's dog's bark object to see if it is
            // equal to the Bark instance supplied by Doug's hardware, using Bark.equals()
            Console.WriteLine("BarkRecognizer: Heard a '{0}'", bark.getSound());
            if ((door.getAllowedBark().equals(bark)))
                door.Open();
            else
                Console.WriteLine("This dog is not allowed");
        }
    }
}
