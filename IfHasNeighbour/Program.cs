using System;
using System.Linq;

namespace IfHasNeighbour
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
                    Console.WriteLine("Please enter your 3 letter");
                    var value = Console.ReadLine();
                    if (value.Length < 4)
                    {
                        
                        bool inOrder = value.SequenceEqual(value.OrderBy(c => c));
                        if (inOrder)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");   
                        }
                        Console.WriteLine("For exited type exit else press enter");
                        pressed = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input");
                        Console.WriteLine("For exited type exit else press enter");
                        pressed = Console.ReadLine();
                    }
                }
            }
        }
    }
}