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

        public GuitarSpec(Builder builder, string model, GuitarType type, Wood backWood, Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
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

    }
}
