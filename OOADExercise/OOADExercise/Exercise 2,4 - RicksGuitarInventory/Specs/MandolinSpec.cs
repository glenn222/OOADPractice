using OOADExercise.Exercise_2.Enums;

namespace OOADExercise.Exercise_2_4___RicksGuitarInventory
{
    public class MandolinSpec : InstrumentSpec
    {
        private Style style;

        public MandolinSpec(Style style, InstrumentSpec spec) {
            this.style = style;
        }

        public Style getStyle()
        {
            return style;
        }

        // Just like GuitarSpec, MandolinSpec uses its base class to do basic comparison
        // and then casts MandolinSpec and compares mandolin-specific properties
        public override bool matches(InstrumentSpec searchInstrumentSpec)
        {
            if (!(base.matches(searchInstrumentSpec)))
                return false;
            if (!(searchInstrumentSpec is MandolinSpec))
                return false;
            MandolinSpec spec = (MandolinSpec) searchInstrumentSpec;
            if (style != spec.style)
                return false;
            return true;
        }
    }
}