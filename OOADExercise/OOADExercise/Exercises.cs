using System;
using OOADExercise.Exercise_2;
using OOADExercise.Exercise_2.Enums;

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
            // Guitar Customer
            // Setup Rick's Guitar inventory
            Inventory inventory = new Inventory();
            inventory = initializeInventory(inventory);

            Guitar customerReq = new Guitar("", 0, Builder.FENDER, "Stratocastor", GuitarType.ELECTRIC, Wood.ALDER, Wood.ALDER);
            Guitar guitar = inventory.search(customerReq);

            if (guitar != null)
                Console.WriteLine("Customer, you might want this {0} {1} {2} guitar:\n  {3} back and sides,\n  {4} top.\n You can have it for only ${5}!",
                   BuilderExtensionMethods.toString(guitar.getBuilder()),
                   guitar.getModel(),
                   TypeExtensionMethods.toString(guitar.getType()),
                   WoodExtensionMethods.toString(guitar.getBackWood()),
                   WoodExtensionMethods.toString(guitar.getTopWood()),
                   guitar.getPrice());
            else
                Console.WriteLine("Sorry customer, we don't have anything for you.");

        }

        private static Inventory initializeInventory(Inventory inventory)
        {
            //Add guitars to our inventory.
            inventory.addGuitar("V95693", 1499.95, Builder.FENDER, "Stratocastor", GuitarType.ELECTRIC, Wood.ALDER, Wood.ALDER);

            return inventory;
        }
    }
}
