namespace OOADExercise
{
    public class Jet : Airplane
    {
        private static int MULTIPLIER = 2;

        public Jet() : base()
        {
        }

        public override void setSpeed(int speed)
        {
            base.setSpeed(speed * MULTIPLIER);
        }

        public void accelerate()
        {
            base.setSpeed(getSpeed() * 2);
        }
    }
}
