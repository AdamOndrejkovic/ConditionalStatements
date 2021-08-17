using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsistsOfUppercase
{
    public class Program1
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
                    Console.WriteLine("Please enter 3 characters");
                    var input = Console.ReadLine();
                    if (input.Length < 4)
                    {
                        bool onlyUpper = input.Any(char.IsUpper);

                        if (onlyUpper)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }

                        Console.WriteLine();
                        Console.WriteLine("For exited type exit else press enter");
                        pressed = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You have entered incorrect input");
                        Console.WriteLine("For exited type exit else press enter");
                        pressed = Console.ReadLine();
                    }
                }
            }
        } 
    }
}