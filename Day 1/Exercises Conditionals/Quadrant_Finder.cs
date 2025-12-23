using System;

class QuadrantFinder
{
    static void Main()
    {
        Console.Write("Enter x coordinate: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter y coordinate: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Point lies in Quadrant I");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Point lies in Quadrant II");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Point lies in Quadrant III");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Point lies in Quadrant IV");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("Point lies at the Origin");
        }
        else if (x == 0)
        {
            Console.WriteLine("Point lies on the Y-axis");
        }
        else if (y == 0)
        {
            Console.WriteLine("Point lies on the X-axis");
        }
    }
}
