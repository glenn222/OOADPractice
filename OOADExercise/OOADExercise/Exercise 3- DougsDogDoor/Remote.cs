using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace OOADExercise.Exercise_3__DougsDogDoor
{
    public class Remote
    {
        private DogDoor door;

        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void pressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (door.isOpen())
            {
                door.Close();
            }
            else
            {
                door.Open();
            }
        }
    }
}
