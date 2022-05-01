using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        var pizzaprice = 0.00;
        var toppingprice = 0.00;
        var totalprice = 0.00;
        var tax = 0.00;
        double pizzasize;
        double toppings;

        Console.WriteLine("Please enter size of you pizza");
        Console.WriteLine("");

        Console.Write("pizza size? (1: lagre / 2 extralarge):");
        pizzasize = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Toppings? :");
        toppings = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if (pizzasize == 1)
        {
            pizzaprice = 6.00;
        }
        if (pizzasize == 2)
        {
            pizzaprice = 10.00;
        }

        if (toppings == 1)
        {
            toppingprice = 1.00;
        }
        if (toppings == 2)
        {
            toppingprice = 1.75;
        }
        if (toppings == 3)
        {
            toppingprice = 2.50;
        }
        if (toppings == 4)
        {
            toppingprice = 3.35;
        }

        tax = (pizzaprice + toppingprice) * 0.13;
        totalprice = (pizzaprice + toppingprice) + tax;

        Console.WriteLine("Your pizza will cost  $" + totalprice.ToString("0.00"));

        Console.WriteLine("\nDone.");
    }
}