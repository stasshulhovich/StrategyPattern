namespace StrategyPattern.Interfaces.Quack
{
    public class Quack : QuackBehaviour
    {
        void QuackBehaviour.Quack()
        {
            Console.WriteLine("Quack subclass");
        }
    }
}
