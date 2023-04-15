using StrategyPattern.Interfaces.Fly;
using StrategyPattern.Interfaces.Quack;

namespace StrategyPattern.DuckLife
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehaviour = new Squeak();
            FlyBehaviour = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("RubberDuck display");
        }
    }
}