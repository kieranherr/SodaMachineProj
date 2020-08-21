using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SodaMachine
{
    public static class UserInterface
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the vending machine!");
            Console.ReadLine();
        }
       public static Can WhatDrink(SodaMachine sodaMachine)
        { 
            Console.WriteLine("We have Coke, A&W, and Fanta.");
            Console.WriteLine("What drink would you like to purchase?");
            Cola cola = new Cola();
            if(sodaMachine.inventory.Contains(cola))
            {
                Console.WriteLine("We have that in stock!");
                return cola;
            }
            else
            {
                Console.WriteLine("Coke is out of stock sorry! Please choose a different soda.");
                Console.ReadLine();
            }
        }
    }
}
