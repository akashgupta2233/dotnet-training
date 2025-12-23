using System;

class ProfitLoss
{
    static void Main()
    {
        Console.Write("Enter Cost Price: ");
        double cp = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Selling Price: ");
        double sp = Convert.ToDouble(Console.ReadLine());

        if (sp > cp)
        {
            double profit = sp - cp;
            double profitPercent = (profit / cp) * 100;
            Console.WriteLine("Profit = " + profit);
            Console.WriteLine("Profit Percentage = " + profitPercent + "%");
        }
        else if (sp < cp)
        {
            double loss = cp - sp;
            double lossPercent = (loss / cp) * 100;
            Console.WriteLine("Loss = " + loss);
            Console.WriteLine("Loss Percentage = " + lossPercent + "%");
        }
        else
        {
            Console.WriteLine("No Profit, No Loss");
        }
    }
}
