using System.Collections.Generic;

namespace SodaMachine
{
    public class SodaMachine
    {
        public List<Coin> register;
        public List<Can> inventory;
        public List<Coin> temporaryRegister;

        public SodaMachine()
        {
            register = new List<Coin>();
            inventory = new List<Can>();
            temporaryRegister = new List<Coin>();
            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                register.Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                register.Add(dime);
            }
            for (int i = 0; i < 20; i++)
            {
                Nickle nickle = new Nickle();
                register.Add(nickle);
            }
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                register.Add(penny);
            }
            for (int i = 0; i < 10; i++)
            {
                RootBeer rootBeer = new RootBeer();
                Cola cola = new Cola();
                OrangeSoda orangeSoda = new OrangeSoda();
                inventory.Add(cola);
                inventory.Add(rootBeer);
                inventory.Add(orangeSoda);
            }
        }
        public double RunningTotal()
        {
            double total = 0;
            foreach (Coin coin in temporaryRegister)
            {
                total += coin.Amount;
            }
            return total;
        }
    }
}
