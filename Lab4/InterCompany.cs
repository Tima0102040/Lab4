using System;

namespace Lab4
{
    public class InterCompany: Interface
        {
            public string Product { get; set; }
            public int GeneralMoney { get; set; }
            public int Profit { get; set; }
            public int NumberWorker { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
            public string Activity { get; set; }

            public InterCompany()
            {
                Console.Write("Name: ");
                Name = Console.ReadLine();
                Console.Write("Location: ");
                Location = Console.ReadLine();
                Console.Write("Activity: ");
                Activity = Console.ReadLine();
            }

            public void CountEmployee(int salary, int allMoney)
            {
                int balance = allMoney - Profit;
                int fondZP = (balance / 100) * 70;
                NumberWorker = fondZP / salary;
            }

            public void CountProfit(int percent, int cost)
            {
                Profit = (cost / 100) * percent;
            }
        }
}