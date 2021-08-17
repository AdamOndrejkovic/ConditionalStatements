using System;

namespace IfNumberContains3
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
                    var number = int.Parse(Console.ReadLine());

                    bool hasFound = false;
                    
                    while (number > 0)
                    {
                        if (number % 10 == 3)
                        {
                            hasFound = true;
                            break;
                        }
                        number = number/10;
                        
                    }


                    if (hasFound)
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