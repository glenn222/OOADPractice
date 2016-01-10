using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOADExercise.Exercise_2;

namespace OOADExercise.Exercise_2_4___RicksGuitarInventory
{
    public abstract class Instrument
    {
        private string serialNumber;
        private double price;
        private InstrumentSpec instrumentSpec;

        public Instrument(string serialNumber, double price, InstrumentSpec instrumentSpec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.instrumentSpec = instrumentSpec;
        }

        public string getSerialNumber()
        {
            return serialNumber;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(float newPrice)
        {
            this.price = newPrice;
        }

        public InstrumentSpec getSpec()
        {
            return instrumentSpec;
        }
    }
}
