using System;

namespace LessonOne
{
    class Task3
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
                        Console.WriteLine("devision by zero is not possible");
                    }

                    else {
                    Console.WriteLine(a / b);
                    }
                    
                    break;
            }
        }
    }
}
