using System;

class LeapYearChecker
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0)
        {
            Console.WriteLine(year + " is a Leap Year");
        }
        else if (year % 4 == 0 && year % 100 != 0)
        {
            Console.WriteLine(year + " is a Leap Year");
        }
        else
        {
            Console.WriteLine(year + " is NOT a Leap Year");
        }
    }
}
