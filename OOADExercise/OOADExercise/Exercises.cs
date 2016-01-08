using System;
using OOADExercise.Exercise_2;
using OOADExercise.Exercise_2.Enums;
using System.Collections.Generic;
using System.Linq;

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
            GuitarSpec customerSpec = new GuitarSpec(Builder.FENDER, "Stratocastor", GuitarType.ELECTRIC, 12, Wood.ALDER, Wood.ALDER);

            List<Guitar> guitars = inventory.search(customerSpec);

            if (guitars.Any())
            {
                foreach (Guitar guitar in guitars)
                {
                    GuitarSpec guitarSpec = guitar.getSpec();
                    Console.WriteLine("Customer, you might want this {0} {1} {2} guitar:\n  {3} back and sides,\n  {4} top.\n You can have it for only ${5}!",
                    BuilderExtensionMethods.toString(guitarSpec.getBuilder()),
                    guitarSpec.getModel(),
                    TypeExtensionMethods.toString(guitarSpec.getType()),
                    WoodExtensionMethods.toString(guitarSpec.getBackWood()),
                    WoodExtensionMethods.toString(guitarSpec.getTopWood()),
                    guitar.getPrice());
                    Console.WriteLine("---------------------------");
                }
            }
            else
                Console.WriteLine("Sorry customer, we don't have anything for you.");

        }

        private static Inventory initializeInventory(Inventory inventory)
        {
            GuitarSpec guitarSpec = new GuitarSpec(Builder.FENDER, "Stratocastor", GuitarType.ELECTRIC, 12, Wood.ALDER, Wood.ALDER);
            //Add guitars to our inventory.
            inventory.addGuitar("V95693", 1499.95, guitarSpec);
            inventory.addGuitar("V9512", 1549.95, guitarSpec);
            return inventory;
        }
    }
}
