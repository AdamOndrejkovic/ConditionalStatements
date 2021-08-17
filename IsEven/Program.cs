using System;

namespace IsEven
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
                    var input = int.Parse(Console.ReadLine());
                    if (input % 2 == 0)
                    {
                        Console.WriteLine("Even");
                        Console.WriteLine("For exited type exit else press enter");
                        pressed = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Odd");
                        Console.WriteLine("For exited type exit else press enter");
                        pressed = Console.ReadLine();
                    }
                }
            }
        }
    }
}