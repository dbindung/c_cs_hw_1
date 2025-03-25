using System;

namespace LessonOne
{
    class Program
    {
        static void Main()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                
                case "-":
                    Console.WriteLine(a - b);
                    break;
                    
                case "*":
                    Console.WriteLine(a * b);
                    break;
                
                case "/":
                    if (b == 0) {
                        Console.WriteLine("Isn't possible devision by zero");
                    }

                    else {
                    Console.WriteLine(a / b);
                    }
                    
                    break;
            }

            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(name + " " + age);
        }
    }
}
