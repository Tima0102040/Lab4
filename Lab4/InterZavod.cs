namespace Lab4
{
    public class InterZavod: InterCompany
    {
        public InterZavod (string product, int generalMoney, int profit, int numberWorker)
        {
            Product = product;
            GeneralMoney = generalMoney;
            Profit = profit;
            NumberWorker = numberWorker;
        }
    }
}