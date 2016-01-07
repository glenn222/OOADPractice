using System;
using OOADExercise.Exercise_2;

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
            // Setup Rick's Guitar inventory
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            Guitar customerReq = new Guitar("", 0, "fender", "Stratocastor", "electric", "Alder", "Alder");
            Guitar guitar = inventory.search(customerReq);

            if (guitar != null)
                Console.WriteLine("Customer, might want this {0} {1} {2} guitar:\n  {4} back and sides,\n  {5} top.\n You can have it for only ${6}!",
                    guitar.getBuilder(), guitar.getModel(), guitar.getType(), guitar.getBackWood(), guitar.getTopWood(), guitar.getPrice());
            else
                Console.WriteLine("Sorry customer, we don't have anything for you.");

        }

        private static void initializeInventory(Inventory inventory)
        {
            //Add guitars to our inventory.
        }
    }
}
