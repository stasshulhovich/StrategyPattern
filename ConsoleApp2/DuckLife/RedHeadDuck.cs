using StrategyPattern.Interfaces.Fly;
using StrategyPattern.Interfaces.Quack;

namespace StrategyPattern.DuckLife
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            QuackBehaviour = new Squeak();
            FlyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("RedHeadDuck display");
        }
    }
}