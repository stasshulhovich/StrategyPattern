using StrategyPattern.DuckLife;

public class Program
{
    public static void Main()
    {
        var mallardDuck = new MallardDuck();
        var redHeadDuck = new RedHeadDuck();
        var decoyDuck = new DecoyDuck();
        var rubberDuck = new RubberDuck();

        List<Duck> ducks = new List<Duck> { mallardDuck, redHeadDuck, decoyDuck, rubberDuck };


        foreach (var duck in ducks)
        {
            Console.WriteLine("///////////////////////////////////////////////////");
            Console.WriteLine($"This is {duck.GetType().Name}");
            duck.PerformQuack();
            duck.PerformFly();
        }
        Console.ReadLine();
    }
}