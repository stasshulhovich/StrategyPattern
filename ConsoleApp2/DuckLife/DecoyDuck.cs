using StrategyPattern.Interfaces.Fly;
using StrategyPattern.Interfaces.Quack;

namespace StrategyPattern.DuckLife
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            QuackBehaviour = new Mute();
            FlyBehaviour = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("DecoyDuck display");
        }
    }
}