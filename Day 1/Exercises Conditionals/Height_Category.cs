using System;

class HeightCategory
{
    static void Main()
    {
        Console.Write("Enter height in cm: ");
        int height = Convert.ToInt32(Console.ReadLine());

        if (height < 150)
        {
            Console.WriteLine("Category: Dwarf");
        }
        else if (height >= 150 && height <= 165)
        {
            Console.WriteLine("Category: Average");
        }
        else if (height > 165 && height <= 190)
        {
            Console.WriteLine("Category: Tall");
        }
        else
        {
            Console.WriteLine("Category: Abnormal");
        }
    }
}
