using System.CodeDom;
using System.Collections.Generic;
using System;
namespace SodaMachine
{
    class Simulation
    {
        public SodaMachine sodaMachine;
        public Customer customer;
        public Simulation()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();
            customer.InsertMoney();
            //need method to calculate "running total" of coin values
           
            //Can can = UserInterface.WhatDrink(sodaMachine);
            //CheckMoney(can, sodaMachine.temporaryRegister);
        }
        public void CheckMoney(Can can, List<Coin> coins, double totalCoinValueInserted)
        {
            if (can.Cost > totalCoinValueInserted)
            {
                Console.WriteLine("not enough coins entered");
                Console.ReadLine();
                customer.wallet.coins.AddRange(coins);
            }
            else if (can.Cost == totalCoinValueInserted)
            {
                //no change returned, just dispense the soda
                Console.WriteLine("Give Soda");
                Console.ReadLine();
                sodaMachine.inventory.Remove(can);
                customer.backpack.cans.Add(can);
                customer.backpack.cans.ForEach(Console.WriteLine);


            }
            else if(can.Cost < totalCoinValueInserted && sodaMachine.register.Count != 0 && sodaMachine.inventory.Contains(can))
            {
                //return the change left over after minusing the cost of the can
                //dispense soda as well
                Console.WriteLine("Dispense and also give change");
                Console.ReadLine();
            }

            
        }
    }
}
