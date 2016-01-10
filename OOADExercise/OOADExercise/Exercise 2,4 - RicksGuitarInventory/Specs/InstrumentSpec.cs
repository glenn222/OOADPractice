using OOADExercise.Exercise_2.Enums;

namespace OOADExercise.Exercise_2_4___RicksGuitarInventory
{
    public abstract class InstrumentSpec
    {
        private Builder builder;
        private string model;
        private InstrumentType type;
        private Wood backWood;
        private Wood topWood;

        public InstrumentSpec(Builder builder, string model, InstrumentType type, Wood backWood, Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }

        public InstrumentSpec() { }

        public Builder getBuilder()
        {
            return builder;
        }

        public string getModel()
        {
            return model;
        }

        public InstrumentType getType()
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

        public virtual bool matches(InstrumentSpec searchInstrumentSpec)
        {
            // No need to indirectly call a method to get the InstrumentSpecs anymore, we can directly refer specs to its properties
            if (searchInstrumentSpec.builder != builder)
                return false;
            if ((model != null) && (!model.Equals("")) && !model.Equals(searchInstrumentSpec.model))
                return false;
            if (searchInstrumentSpec.type != type)
                return false;
            if (searchInstrumentSpec.backWood != backWood)
                return false;
            if (searchInstrumentSpec.topWood != topWood)
                return false;

            return true;

        }
    }
}