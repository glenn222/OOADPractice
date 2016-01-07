using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADExercise
{
    class Exercises
    {

        public Exercises()
        {

        }

        // Exercise 1 demonstrates inheritance and polymorphism
        public void Exercise1()
        {
            Airplane airplane = new Airplane();
            Airplane jet = new Jet();

            airplane.setSpeed(20);
            Console.WriteLine(airplane.getSpeed());

            jet.setSpeed(30);
            Console.WriteLine(jet.getSpeed());
        }

        public void Exercise2()
        {

        }

    }
}
