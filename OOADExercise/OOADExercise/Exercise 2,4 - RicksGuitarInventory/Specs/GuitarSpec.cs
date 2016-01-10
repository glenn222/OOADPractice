using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOADExercise.Exercise_2.Enums;
using OOADExercise.Exercise_2_4___RicksGuitarInventory;

namespace OOADExercise.Exercise_2
{
    public class GuitarSpec : InstrumentSpec
    {
        private int numStrings;

        public GuitarSpec(Builder builder, string model, InstrumentType type, int numStrings, Wood backWood, Wood topWood)
            : base(builder, model, type, backWood, topWood)
        {
            this.numStrings = numStrings;
        }

        public int getNumStrings()
        {
            return numStrings;
        }

        // matches() uses the superclass's matches() and then performs additional checks to make sure the spec is the right type
        // and matches the guitar-specific properties
        public override bool matches(InstrumentSpec searchInstrumentSpec)
        {
            if (!base.matches(searchInstrumentSpec))
                return false;
            if (!(searchInstrumentSpec is GuitarSpec))
                return false;
            GuitarSpec spec = (GuitarSpec)searchInstrumentSpec;
            if (numStrings != spec.numStrings)
                return false;
            return true;
        }
    }
}
