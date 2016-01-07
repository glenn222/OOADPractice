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
                string builder = searchGuitar.getBuilder();
                string model = searchGuitar.getModel();
                string type = searchGuitar.getType();
                string backWood = searchGuitar.getBackWood();
                string topWood = searchGuitar.getTopWood();

                if ((builder != null) && (!builder.Equals("")) && !builder.Equals(guitar.getBuilder()))
                    continue;
                if ((model != null) && (!model.Equals("")) && !model.Equals(guitar.getModel()))
                    continue;
                if ((type != null) && (!type.Equals("")) && !type.Equals(guitar.getBuilder()))
                    continue;
                if ((backWood != null) && (!backWood.Equals("")) && !backWood.Equals(guitar.getBackWood()))
                    continue;
                if ((topWood != null) && (!topWood.Equals("")) && !topWood.Equals(guitar.getTopWood()))
                    continue;
            }

            return null;
        }
    }
}
