using System;

namespace DivisibleBy2Or3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasExited = false;
            var pressed = "";
            while (!hasExited)
            {
                if (pressed.Equals("exit"))
                {
                    hasExited = true;
                }
                else
                {
                    Console.WriteLine("Please enter your first number");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your second number");
                    int secondNumber = int.Parse(Console.ReadLine());
                    if (
                        (number % 2 == 0 || number % 3 == 0) &&
                        (secondNumber % 2 == 0 || secondNumber % 3 == 0)
                        )
                    {
                        Console.WriteLine(number * secondNumber);
                        Console.WriteLine("For exited type exit else press enter");
                        pressed = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(number + secondNumber);
                        Console.WriteLine("For exited type exit else press enter");
                        pressed = Console.ReadLine();
                    }
                }
            }
        }
    }
}