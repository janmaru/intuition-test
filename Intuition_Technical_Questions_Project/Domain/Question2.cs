namespace Intuition.Technical.Questions.Question2
{
    public abstract class Vehicle
    {
        public abstract double Speed();
    }
    public class Car : Vehicle
    {
        public override double Speed()
        {
            return 351;
        }
    }
    public class Truck : Vehicle
    {
        public override double Speed()
        {
            return 465;
        }
    }

    public class Train : Vehicle
    {
        public override double Speed()
        {
            return 616;
        }
    }

    public class Program
    {
        private readonly Vehicle vehicle;
        public Program(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public  double Speed()
        {
            return vehicle.Speed();
        }
    }
}
