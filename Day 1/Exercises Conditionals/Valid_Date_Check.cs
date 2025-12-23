using System;

class ValidDateCheck
{
    static void Main()
    {
        Console.Write("Enter day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        bool isValid = true;

        if (month < 1 || month > 12)
        {
            isValid = false;
        }
        else
        {
            int daysInMonth;

            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    daysInMonth = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                        daysInMonth = 29;
                    else
                        daysInMonth = 28;
                    break;
                default:
                    daysInMonth = 0;
                    break;
            }

            if (day < 1 || day > daysInMonth)
            {
                isValid = false;
            }
        }

        if (isValid)
            Console.WriteLine("Valid Date");
        else
            Console.WriteLine("Invalid Date");
    }
}
