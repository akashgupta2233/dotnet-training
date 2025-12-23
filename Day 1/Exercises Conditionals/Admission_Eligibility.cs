using System;

class AdmissionEligibility
{
    static void Main()
    {
        Console.Write("Enter marks in Mathematics: ");
        int math = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks in Physics: ");
        int phys = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks in Chemistry: ");
        int chem = Convert.ToInt32(Console.ReadLine());

        int total = math + phys + chem;

        if (math >= 65 && phys >= 55 && chem >= 50)
        {
            if (total >= 180 || (math + phys) >= 140)
            {
                Console.WriteLine("Candidate is Eligible for Admission");
            }
            else
            {
                Console.WriteLine("Candidate is NOT Eligible for Admission");
            }
        }
        else
        {
            Console.WriteLine("Candidate is NOT Eligible for Admission");
        }
    }
}
