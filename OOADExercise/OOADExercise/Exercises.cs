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

        public void RicksStringInstrumentsStore()
        {
            // Guitar Customer
            // Setup Rick's Guitar inventory
            Inventory inventory = new Inventory();

            inventory = initializeInventory(inventory);
            InstrumentSpec customerSpec = new GuitarSpec(Builder.FENDER, "Stratocastor", InstrumentType.ELECTRIC, 12, Wood.ALDER, Wood.ALDER);

            List<Instrument> instruments = inventory.search(customerSpec);

            if (instruments.Any())
            {
                foreach (Instrument instrument in instruments)
                {
                    InstrumentSpec instrumentSpec = (InstrumentSpec)instrument.getSpec();
                    Console.WriteLine("Customer, you might want this {0} {1} {2} guitar:\n  {3} back and sides,\n  {4} top.\n You can have it for only ${5}!",
                    BuilderExtensionMethods.toString(instrumentSpec.getBuilder()),
                    instrumentSpec.getModel(),
                    TypeExtensionMethods.toString(instrumentSpec.getType()),
                    WoodExtensionMethods.toString(instrumentSpec.getBackWood()),
                    WoodExtensionMethods.toString(instrumentSpec.getTopWood()),
                    instrument.getPrice());
                    Console.WriteLine("---------------------------");
                }
            }
            else
                Console.WriteLine("Sorry customer, we don't have anything for you.");

        }

        private static Inventory initializeInventory(Inventory inventory)
        {
            GuitarSpec instrumentSpec = new GuitarSpec(Builder.FENDER, "Stratocastor", InstrumentType.ELECTRIC, 12, Wood.ALDER, Wood.ALDER);
            //Add guitars to our inventory.
            inventory.addInstrument("V95693", 1499.95, instrumentSpec);
            inventory.addInstrument("V9512", 1549.95, instrumentSpec);
            return inventory;
        }

        public void DougsDogDoors()
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
            } catch (ThreadInterruptedException) { }

            Console.WriteLine("Bruce starts barking.");
            barkRecognizer.Recognize(new Bark("rooowlf"));

            Console.WriteLine("\n Bruce's back inside");
        }

        private void DogLockedOut(BarkRecognizer recognizer)
        {
            try {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException) {}
            Console.WriteLine("\nBruce's all done...");
            Console.WriteLine("...but he's stuck outside!");
        }
    }
}
