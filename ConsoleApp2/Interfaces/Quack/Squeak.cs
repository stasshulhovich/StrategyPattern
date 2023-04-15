namespace StrategyPattern.Interfaces.Quack
{
    public class Squeak : QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak subclass");
        }
    }
}