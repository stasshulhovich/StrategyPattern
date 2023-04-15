namespace StrategyPattern.Interfaces.Quack
{
    public class Mute : QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Mute subclass");
        }
    }
}
