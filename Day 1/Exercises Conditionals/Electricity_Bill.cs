using System;

class ElectricityBill
{
    static void Main()
    {
        Console.Write("Enter total units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());

        double bill = 0;

        if (units <= 199)
        {
            bill = units * 1.20;
        }
        else if (units >= 200 && units <= 400)
        {
            bill = units * 1.50;
        }
        else if (units >= 401 && units <= 600)
        {
            bill = units * 1.80;
        }
        else
        {
            bill = units * 2.00;
        }

        if (bill > 400)
        {
            bill = bill + (bill * 0.15);
        }

        Console.WriteLine("Total Bill = Rs. " + bill);
    }
}
