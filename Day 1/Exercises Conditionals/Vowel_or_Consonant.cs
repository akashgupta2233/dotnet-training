using System;

class VowelOrConsonant
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = Convert.ToChar(Console.ReadLine().ToLower()); 

        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine(ch + " is a Vowel");
                break;

            default:
                Console.WriteLine(ch + " is a Consonant");
                break;
        }
    }
}
