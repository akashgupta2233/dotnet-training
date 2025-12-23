using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double d = b * b - 4 * a * c; // discriminant

        if (d > 0)
        {
            double r1 = (-b + Math.Sqrt(d)) / (2 * a);
            double r2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("Roots are real and different:");
            Console.WriteLine("Root1 = " + r1);
            Console.WriteLine("Root2 = " + r2);
        }
        else if (d == 0)
        {
            double r = -b / (2 * a);
            Console.WriteLine("Roots are real and equal:");
            Console.WriteLine("Root = " + r);
        }
        else
        {
            Console.WriteLine("Roots are imaginary (complex).");
        }
    }
}
