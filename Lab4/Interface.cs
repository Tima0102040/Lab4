namespace Lab4
{
    public interface Interface
    {
        string Name { get; set; }
        string Location { get; set; }
        string Activity { get; set; } 
        string Product { get; set; }
        int GeneralMoney { get; set; }
        int Profit { get; set; } 
        int NumberWorker { get; set; } 
        
        void CountEmployee(int salary, int allMoney);
        void CountProfit(int percent, int cost);
    }
}