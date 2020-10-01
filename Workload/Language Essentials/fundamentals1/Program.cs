using System;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 255; i++)
            {
                System.Console.WriteLine(i);
            }

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 != 0)
                    {
                        System.Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        System.Console.WriteLine("FizzBuzz");
                    }
                }
                else if (i % 5 == 0)
                {
                    if (i % 3 != 0)
                    {
                        System.Console.WriteLine("Buzz");
                    }
                }
            }
        }
    }
}
