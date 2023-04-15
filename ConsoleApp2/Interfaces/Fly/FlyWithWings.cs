namespace StrategyPattern.Interfaces.Fly
{
    public class FlyWithWings : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Fly with wings subclass");
        }
    }
}