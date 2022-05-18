using System;

namespace Lab4
{
    public class Zavod:Company
    {
        private string product;//тип продукції
        private int generalMoney;// обсяг підприємства
        private int profit;//прибуток
        private int numberWorker;//к-сть працівників
        
        public Zavod(string product, int generalMoney, int profit, int numberWorker) 
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