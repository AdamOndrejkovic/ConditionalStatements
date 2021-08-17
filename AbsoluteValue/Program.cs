using System;

namespace ConditionalStatements
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
                    Console.WriteLine("Please enter your number");
                    int number = int.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("Absolute value is: " + (number / -1));
                        Console.WriteLine("For exited type exit else press enter");
                        pressed = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Absolute value is: " + number);
                        Console.WriteLine("For exited type exit else press enter");
                        pressed = Console.ReadLine();
                    }
                }
            }
        }
    }
}