using System;
using System.Linq;

namespace ConsistsOfUppercase
{
    class Program
    {
        /*static void Main(string[] args)
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
                        var characters = input.ToArray();
                        int counter = 0;
                        foreach (var character in characters)
                        {
                            if (Char.IsUpper(character))
                            {
                                counter++;
                            }
                        }

                        if (counter == 3)
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
        }*/
    }
}