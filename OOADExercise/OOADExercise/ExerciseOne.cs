using System;
using System.Collections.Generic;
using System.Linq;
using OOADExercise.Exercise_2;
using OOADExercise.Exercise_2.Enums;
using OOADExercise.Exercise_3__DougsDogDoor;
using System.Threading;
using OOADExercise.Exercise_2_4___RicksGuitarInventory;

namespace OOADExercise
{
    class ExerciseOne
    {
        // Exercise 1 demonstrates inheritance and polymorphism
        public void RunExerciseOne()
        {
            Airplane airplane = new Airplane();
            Airplane jet = new Jet();

            airplane.setSpeed(20);
            Console.WriteLine(airplane.getSpeed());

            jet.setSpeed(30);
            Console.WriteLine(jet.getSpeed());
        }
    }
}
