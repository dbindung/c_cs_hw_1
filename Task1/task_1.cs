using System;

class Task1
{
    static void Main()
    {
        Console.WriteLine("enter your birth date:");
        int birthDate = Convert.ToInt32(Console.ReadLine());

        const int currentYear = 2025;

        if (currentYear - birthDate > 18) {
            Console.WriteLine("you are an adult");
        }
        else {
            Console.WriteLine("you are underaged");
        }
    }
}



