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
        public void addGuitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
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
        public Guitar search(Guitar searchGuitar)
        {
            for (int i = 0; i < guitars.Count(); i++)
            {
                Guitar guitar = guitars[i];
                // Ignore price & serial number since they're unique
                string model = searchGuitar.getModel().ToLower();

                if (searchGuitar.getBuilder() != guitar.getBuilder())
                    continue;
                if ((model != null) && (!model.Equals("")) && !model.Equals(guitar.getModel().ToLower()))
                    continue;
                if (searchGuitar.getType() != guitar.getType())
                    continue;
                if (searchGuitar.getBackWood() != guitar.getBackWood())
                    continue;
                if (searchGuitar.getTopWood() != guitar.getTopWood())
                    continue;
                return guitar;
            }

            return null;
        }
    }
}
