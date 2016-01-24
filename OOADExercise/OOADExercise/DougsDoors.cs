using OOADExercise.Exercise_3__DougsDogDoor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOADExercise
{
    class DougsDoors
    {
        public void RunSimulator()
        {
            // Dog Door Simulator

            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            //Create the BarkRecognizer, connect it to the door, and let it listen for some barking.
            BarkRecognizer barkRecognizer = new BarkRecognizer(door);

            String sound = "bark";
            Bark bark = new Bark(sound);
            //Thread currentThread = Thread.CurrentThread;

            door.addAllowedBark(new Bark("rowlf"));
            door.addAllowedBark(new Bark("rooowlf"));
            door.addAllowedBark(new Bark("rawlf"));
            door.addAllowedBark(new Bark("woof"));


            // Simulate the hardware hearing a bark
            Console.WriteLine("Bruce starts barking.");
            barkRecognizer.Recognize(new Bark("rowlf"));

            Console.WriteLine("\nBruce has gone outside...");
            DogLockedOut(barkRecognizer);

            // Simulate the hardware hearing a bark (not Bruce!)
            Bark smallDogBark = new Bark("yip");
            Console.WriteLine("A small dog starts barking");
            barkRecognizer.Recognize(smallDogBark);

            try
            {
                Thread.Sleep(5000);
            }
            catch (ThreadInterruptedException) { }

            Console.WriteLine("Bruce starts barking.");
            barkRecognizer.Recognize(new Bark("rooowlf"));

            Console.WriteLine("\n Bruce's back inside");
        }

        private void DogLockedOut(BarkRecognizer recognizer)
        {
            try
            {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException) { }
            Console.WriteLine("\nBruce's all done...");
            Console.WriteLine("...but he's stuck outside!");
        }
    }
}
