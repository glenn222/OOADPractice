using OOADExercise.Exercise_2.Enums;

namespace OOADExercise.Exercise_2
{
    public class Guitar
    {
        private string serialNumber, model;
        Builder builder;
        GuitarType type;
        Wood backWood;
        Wood topWood;
        private double price;

        public Guitar(string serialNumber, double price, Builder builder, string model, GuitarType type, Wood backWood, Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
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
