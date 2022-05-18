namespace Lab4
{
    public class AbsZavod: Abstraction
    {
        protected string product;//тип продукції
        protected int generalMoney;// обсяг підприємства
        protected int profit;//прибуток
        protected int numberWorker;//к-сть працівників
        
        public AbsZavod(string product, int generalMoney, int profit, int numberWorker) :base()
        {
            this.product = product;
            this.generalMoney = generalMoney;
            this.profit = profit;
            this.numberWorker = numberWorker;
        }

        
        public string Product
        {
            set { product = value; }
            get { return product; }
        }
        
        public int GeneralMoney
        {
            set { generalMoney = value; }
            get { return generalMoney; }
        }
        
        public int Profit
        {
            set { profit = value; }
            get { return profit; }
        }
        
        public int NumberWorker
        {
            set { numberWorker = value; }
            get { return numberWorker; }
        }

        public void CountProfit(int percent, int cost)
        {
            Profit = (cost / 100) * percent;
        }
        
        public void CountEmployee(int salary,int allMoney)
        {
            int fondZP;
            int balance = allMoney - profit;
            fondZP = (balance / 100) * 70;
            numberWorker = fondZP / salary;
        }
    }
}