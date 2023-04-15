using StrategyPattern.Interfaces.Fly;
using StrategyPattern.Interfaces.Quack;

namespace StrategyPattern.DuckLife
{
    public abstract class Duck
    {
        protected FlyBehaviour? FlyBehaviour { get; set; }

        protected QuackBehaviour? QuackBehaviour { get; set; }

        public void PerformFly() => FlyBehaviour?.Fly();

        public void PerformQuack() => QuackBehaviour?.Quack();

        public void Swim()
        {
            Console.WriteLine("Swim from base class");
        }

        public abstract void Display();
    }
}