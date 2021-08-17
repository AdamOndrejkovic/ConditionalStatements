using System;

namespace IfLeapYear
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
                    Console.WriteLine("Please enter the year");
                    var value = int.Parse(Console.ReadLine());
                    if (
                        (value % 100 == 0) &&
                        (value % 400 == 0)
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