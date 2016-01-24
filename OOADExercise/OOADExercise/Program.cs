using System;

namespace OOADExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            RicksStore store = new RicksStore();

            store.RunSimulator();

            Console.ReadKey();
        }
    }
}
