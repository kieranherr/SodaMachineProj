using System;
using System.Linq;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            SodaMachine test = new SodaMachine();
            //Coin test
            test.register.ForEach(Console.WriteLine);
            Console.ReadLine();
            Console.WriteLine(test.register.ElementAt(2).Amount + " " + test.register.ElementAt(2).name);
            Console.ReadLine();

            //Can Test
            test.inventory.ForEach(Console.WriteLine);
            Console.ReadLine();
            Console.WriteLine(test.inventory.ElementAt(2).Cost + " " + test.inventory.ElementAt(2).name);
            Console.ReadLine();

        }
    }
}
