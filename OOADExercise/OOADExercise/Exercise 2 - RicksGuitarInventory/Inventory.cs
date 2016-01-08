using System.Collections.Generic;
using System.Linq;

namespace OOADExercise.Exercise_2
{
    public class Inventory
    {
        private List<Guitar> guitars;
        
        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        // addGuitar() takes in all properties required to create a new Guitar instance, creates one, and adds it to the inventory
        public void addGuitar(string serialNumber, double price, GuitarSpec spec)
        {
            Guitar guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }

        public Guitar getGuitar(string serialNumber)
        {
            for (int i = 0; i < guitars.Count(); i++)
            {
                Guitar guitar = guitars[i];
                if (guitar.getSerialNumber().Equals(serialNumber))
                    return guitar;
            }

            return null;
        }

        // The search method compares each property of the Guitar object it's passed in to each Guitar object in Rick's inventory
        // Returns a list of guitars that match the customers specifications of the guitar.
        public List<Guitar> search(GuitarSpec searchGuitarSpec)
        {
            // Delegate responsibility to compare the specifications of guitars
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in guitars)
            {
                if (guitar.getSpec().matches(searchGuitarSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
