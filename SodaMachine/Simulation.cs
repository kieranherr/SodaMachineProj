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
            double regAmt = 0;
            foreach(Coin c in sodaMachine.register)
            {
                regAmt = c.Amount + regAmt;
            }
            if (totalCoinValueInserted < regAmt)
            {
                if (can.Cost > totalCoinValueInserted)
                {
                    Console.WriteLine("not enough coins entered");
                    Console.ReadLine();
                    customer.wallet.coins.AddRange(coins);
                }
                else if (can.Cost == totalCoinValueInserted && sodaMachine.inventory.Contains(can))
                {
                    //no change returned, just dispense the soda
                    Console.WriteLine("Give Soda");
                    Console.ReadLine();
                    sodaMachine.inventory.Remove(can);
                    customer.backpack.cans.Add(can);
                    customer.backpack.cans.ForEach(Console.WriteLine);

                }
                else if (can.Cost < totalCoinValueInserted && sodaMachine.register.Count != 0 && sodaMachine.inventory.Contains(can))
                {
                    //return the change left over after minusing the cost of the can
                    //dispense soda as well
                    Console.WriteLine("Dispense and also give change");
                    Console.ReadLine();
                    sodaMachine.inventory.Remove(can);
                    customer.backpack.cans.Add(can);
                    double change = totalCoinValueInserted - can.Cost;

                }
                else if (sodaMachine.inventory.Contains(can) == false)
                {
                    foreach (Coin c in coins)
                    {
                        customer.wallet.coins.Add(c);
                    }
                }
            }
            else
            {
                foreach (Coin c in coins)
                {
                    customer.wallet.coins.Add(c);
                }
            }
            
        }
        public List<Coin> ChooseCoins(Coin coin, string coinName)
        {
            List<Coin> coins = new List<Coin>();
            while (coinName != "stop")
            {
                if (coinName == "quarter")
                {
                    coin = new Quarter();
                    coins.Add(coin);
                }
                else if (coinName == "nickel")
                {
                    coin = new Nickle();
                    coins.Add(coin);
                }
                else if (coinName == "dime")
                {
                    coin = new Dime();
                    coins.Add(coin);
                }
                else if (coinName == "penny")
                {
                    coin = new Penny();
                    coins.Add(coin);
                }
            }
            return coins;
        }
    }
}
