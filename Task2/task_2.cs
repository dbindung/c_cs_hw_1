using System;

class Task2
{
    static void Main()
    {
        Console.WriteLine("enter current time (0-23):");
        int currentTime = Convert.ToInt32(Console.ReadLine());

        if (currentTime < 6) {
            Console.WriteLine("it is night right now");
        }
        else {
            if (currentTime < 12) {
                Console.WriteLine("it is morning right now");
            }
            else {
                if (currentTime < 18) {
                    Console.WriteLine("it is day right now");
                }
                else {
                    if (currentTime < 24) {
                        Console.WriteLine("it is evening right now");
                    }
                    else {
                        Console.WriteLine("provided data is ambigious");
                    }
                }
            }
        }
    }
}



