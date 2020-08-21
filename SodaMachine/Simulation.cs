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
           
            Can can = UserInterface.WhatDrink(sodaMachine);
            //CheckMoney(can, sodaMachine.temporaryRegister);
        }
        public void CheckMoney(Can can, List<Coin> coins, double totalCoinValueInserted)
        {
            if (can.Cost >= totalCoinValueInserted)
            {
                Console.WriteLine("not enough coins entered");
                Console.ReadLine();
                customer.wallet.coins.AddRange(coins);
            }
            else if (can.Cost == totalCoinValueInserted)
            {
                //no change returned, just dispense the soda

            }
            else if(can.Cost < totalCoinValueInserted && sodaMachine.register.Count != 0 && sodaMachine.inventory.Contains(can))
            {
                //return the change left over after minusing the cost of the can
                //dispense soda as well
            }

            
        }
    }
}
