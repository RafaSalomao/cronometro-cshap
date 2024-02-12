
using System.Security.Policy;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Stopwatch".PadLeft(20 / 2 + "Stopwatch".Length / 2));
                Console.WriteLine(new string('-', 20));
                Console.Write("Set time [seconds]: ");
                int seconds = int.Parse(Console.ReadLine());
                Console.WriteLine("Press [Enter] to start.");
                Console.ReadKey();
                Start(seconds);
                Again();
            }
        }

        static void Start(int seconds)
        {
            int hundredth;

            while (seconds != 0)
            {
                hundredth = 100;
                Console.Clear();
                while (hundredth != 0)
                {
                    Console.Clear();
                    hundredth--;
                    Console.WriteLine($"{seconds}:{hundredth}");
                    Thread.Sleep(1);
                }
                seconds--;
            }
            Console.Clear();
            Console.WriteLine("End...");
        }

        static void Again()
        {
            Console.Write("Again? [Yes/No]: ");
            string input = Console.ReadLine().ToLower();
            char option = char.Parse(input[0].ToString());

            if (option == 'n')
            {
                Console.WriteLine("Closing...");
                Environment.Exit(0);
            }
        }
    }
}