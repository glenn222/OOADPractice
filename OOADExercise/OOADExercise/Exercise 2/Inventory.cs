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
        public List<Guitar> search(GuitarSpec searchGuitarSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            for (int i = 0; i < guitars.Count(); i++)
            {
                Guitar guitar = guitars[i];
                string model = searchGuitarSpec.getModel().ToLower();

                if (searchGuitarSpec.getBuilder() != guitar.getSpec().getBuilder())
                    continue;
                if ((model != null) && (!model.Equals("")) && !model.Equals(guitar.getSpec().getModel().ToLower()))
                    continue;
                if (searchGuitarSpec.getType() != guitar.getSpec().getType())
                    continue;
                if (searchGuitarSpec.getBackWood() != guitar.getSpec().getBackWood())
                    continue;
                if (searchGuitarSpec.getTopWood() != guitar.getSpec().getTopWood())
                    continue;
                matchingGuitars.Add(guitar);
            }

            return matchingGuitars;
        }
    }
}
