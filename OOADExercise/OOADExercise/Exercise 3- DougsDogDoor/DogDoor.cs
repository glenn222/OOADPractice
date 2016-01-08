using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADExercise.Exercise_3__DougsDogDoor
{
    public class DogDoor
    {
        private bool open;

        public DogDoor()
        {
            this.open = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door is open.");
            open = true;
        }

        public void Close()
        {
            Console.WriteLine("The dog door is closed.");
            open = false;
        }

        //Returns the state of the door, whether open or closed
        public Boolean isOpen()
        {
            return open;
        }
    }
}
