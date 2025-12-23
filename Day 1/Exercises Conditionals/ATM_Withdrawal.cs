using System;

class ATMWithdrawal
{
    static void Main()
    {
        bool cardInserted = true;   
        bool pinValid = true;       
        double balance = 5000;      
        double withdrawAmount;

        Console.Write("Enter amount to withdraw: ");
        withdrawAmount = Convert.ToDouble(Console.ReadLine());

        if (cardInserted)
        {
            if (pinValid)
            {
                if (withdrawAmount <= balance)
                {
                    Console.WriteLine("Transaction Successful! Withdrawn: " + withdrawAmount);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance!");
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN!");
            }
        }
        else
        {
            Console.WriteLine("Please insert your card!");
        }
    }
}
