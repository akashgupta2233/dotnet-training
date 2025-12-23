using System;

class TriangleType
{
    static void Main()
    {
        Console.Write("Enter side a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter side b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter side c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Triangle is Equilateral");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Triangle is Isosceles");
            }
            else
            {
                Console.WriteLine("Triangle is Scalene");
            }
        }
        else
        {
            Console.WriteLine("Not a valid triangle");
        }
    }
}
