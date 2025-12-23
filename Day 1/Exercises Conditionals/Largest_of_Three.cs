using System;

class LargestOfThree
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int largest;

        // Nested if logic
        if (a > b)
        {
            if (a > c)
            {
                largest = a;
            }
            else
            {
                largest = c;
            }
        }
        else
        {
            if (b > c)
            {
                largest = b;
            }
            else
            {
                largest = c;
            }
        }

        Console.WriteLine("Largest number is: " + largest);
    }
}
