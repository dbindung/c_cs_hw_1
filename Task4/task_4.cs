using System;

class Task4
{
    static void Main()
    {
        Console.WriteLine("enter current month (1-12):");
        int currentMonth = Convert.ToInt32(Console.ReadLine());

        switch (currentMonth)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Winter");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Spring");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Summer");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Autumn");
                break;
            default:
                Console.WriteLine("Invalid month. Please enter a number between 1 and 12.");
                break;
        }
    }
}



