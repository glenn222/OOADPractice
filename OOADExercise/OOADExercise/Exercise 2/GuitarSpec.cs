using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOADExercise.Exercise_2.Enums;

namespace OOADExercise.Exercise_2
{
    public class GuitarSpec
    {
        private string model;
        private Builder builder;
        private GuitarType type;
        private Wood backWood;
        private Wood topWood;
        private int numStrings;

        public GuitarSpec(Builder builder, string model, GuitarType type, Wood backWood, Wood topWood, int numStrings)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
            this.numStrings = numStrings;
        }

        public Builder getBuilder()
        {
            return builder;
        }

        public string getModel()
        {
            return model;
        }

        public GuitarType getType()
        {
            return type;
        }

        public Wood getBackWood()
        {
            return backWood;
        }

        public Wood getTopWood()
        {
            return topWood;
        }

        public int getNumStrings()
        {
            return numStrings;
        }

        public List<Guitar> compareSpec(List<Guitar> guitars, GuitarSpec searchGuitarSpec)
        {

            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in guitars)
            {
                GuitarSpec guitarSpec = guitar.getSpec();
                string model = searchGuitarSpec.getModel().ToLower();

                if (searchGuitarSpec.getBuilder() != builder)
                    continue;
                if ((model != null) && (!model.Equals("")) && !model.Equals(this.model.ToLower()))
                    continue;
                if (searchGuitarSpec.getType() != type)
                    continue;
                if (searchGuitarSpec.getBackWood() != backWood)
                    continue;
                if (searchGuitarSpec.getTopWood() != topWood)
                    continue;
                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
           
        }
    }
}
