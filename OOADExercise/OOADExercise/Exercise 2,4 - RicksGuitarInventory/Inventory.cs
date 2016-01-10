using OOADExercise.Exercise_2_4___RicksGuitarInventory;
using System.Collections.Generic;
using System.Linq;

namespace OOADExercise.Exercise_2
{
    public class Inventory
    {
        // Have a generic list of objects
        private List<object> inventory;
        
        public Inventory()
        {
            // Instantiation
            inventory = new List<object>();
        }

        // addGuitar() takes in all properties required to create a new Guitar instance, creates one, and adds it to the inventory
        public void addInstrument(string serialNumber, double price, InstrumentSpec spec)
        {
            Instrument instrument = null;
            if (spec is GuitarSpec)
            {
                instrument = new Guitar(serialNumber, price, (GuitarSpec)spec);
            }
            else if (spec is MandolinSpec)
                instrument = new Mandolin(serialNumber, price, (MandolinSpec)spec);
            inventory.Add(instrument);
        }

        public Instrument getInstrument(string serialNumber)
        {
            foreach (Instrument instrument in inventory)
            {
                if (instrument.getSerialNumber().Equals(serialNumber))
                    return instrument;
            }
            return null;
        }

        // The search method compares each property of the Guitar object it's passed in to each Guitar object in Rick's inventory
        // Returns a list of guitars that match the customers specifications of the guitar.
        public List<Guitar> search(GuitarSpec searchGuitarSpec)
        {
            // Delegate responsibility to compare the specifications of guitars
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in inventory)
            {
                if (guitar.getSpec().matches(searchGuitarSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }

        public List<Mandolin> search(MandolinSpec searchMandolinSpec)
        {
            // Delegate responsibility to compare the specifications of guitars
            List<Mandolin> matchingMandolins = new List<Mandolin>();
            foreach (Mandolin mandolin in inventory)
            {
                if (mandolin.getSpec().matches(searchMandolinSpec))
                    matchingMandolins.Add(mandolin);
            }
            return matchingMandolins;
        }
    }
}
