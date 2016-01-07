namespace OOADExercise
{
    public class Airplane
    {
        private int speed;

        public Airplane()
        {
        }

        public int getSpeed()
        {
            return speed;
        }

        public virtual void setSpeed(int speed)
        {
            this.speed = speed;
        }
    }
}
