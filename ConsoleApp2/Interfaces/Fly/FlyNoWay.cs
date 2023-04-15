namespace StrategyPattern.Interfaces.Fly
{
    public class FlyNoWay : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Fly no way subclass");
        }
    }
}
