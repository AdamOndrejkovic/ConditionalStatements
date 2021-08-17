using System;

namespace GreaterThanThird
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
                    Console.WriteLine("Please enter first number");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter second number");
                    int secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter third number");
                    int thirdNumber = int.Parse(Console.ReadLine());
                    if (
                        (firstNumber + secondNumber > thirdNumber) ||
                        (firstNumber * secondNumber > thirdNumber)
                        )
                    {
                        Console.WriteLine("True");
                        Console.WriteLine("For exited type exit else press enter");
                        pressed = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("False");
                        Console.WriteLine("For exited type exit else press enter");
                        pressed = Console.ReadLine();
                    }
                }
            }
        }
    }
}