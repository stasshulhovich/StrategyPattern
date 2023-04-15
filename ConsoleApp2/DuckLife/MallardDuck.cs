using StrategyPattern.Interfaces.Fly;
using StrategyPattern.Interfaces.Quack;

namespace StrategyPattern.DuckLife
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehaviour = new Quack();
            FlyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("MallarDuck display");
        }
    }
}