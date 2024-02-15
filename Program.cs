using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (byte i = 0; i <= 10; i++)
            {
                for (byte g = 0; g <= 10; g++)
                {
                    Console.WriteLine($"{i} * {g} = {i * g} \n");
                }
                Console.WriteLine("=========");
            }
        }
    }
}
