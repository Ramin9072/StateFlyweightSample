using StateFlyweightSample.Model;

internal class Program
{
    private static void Main(string[] args)
    {

        var order1 =new Order();
        order1.Confirm();

        var order2 = new Order();
        order2.Confirm();

        Console.WriteLine(ReferenceEquals(order1.State , order2.State));

        Console.ReadLine();
    }
}