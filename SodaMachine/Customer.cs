namespace SodaMachine
{
    class Customer
    {
        public Wallet wallet;
        public Backpack backpack;
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();
        }

        public double InsertMoney()
        {
            double money = .35;
            return money;
        }
    }
}
