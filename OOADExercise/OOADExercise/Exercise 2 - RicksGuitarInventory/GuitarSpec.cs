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

        public GuitarSpec(Builder builder, string model, GuitarType type, int numStrings, Wood backWood, Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.numStrings = numStrings;
            this.backWood = backWood;
            this.topWood = topWood;
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

        public bool matches(GuitarSpec searchGuitarSpec)
        {
            // No need to indirectly call a method to get the GuitarSpecs anymore, we can directly refer specs to its properties
            if (searchGuitarSpec.builder != builder)
                return false;
            if ((model != null) && (!model.Equals("")) && !model.Equals(searchGuitarSpec.model))
                return false;
            if (searchGuitarSpec.type != type)
                return false;
            if (searchGuitarSpec.backWood != backWood)
                return false;
            if (searchGuitarSpec.topWood != topWood)
                return false;

            return true;
           
        }
    }
}
