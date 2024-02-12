
using System.ComponentModel.Design.Serialization;
using System.Security.Policy;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {

            int seconds;
            int minutes;

            while (true)
            {
                Menu();

                string inputTime = Console.ReadLine();
                char type = char.Parse(inputTime.Substring(inputTime.Length - 1, 1));

                if (type == 's')
                {
                    seconds = int.Parse(inputTime.Substring(0, inputTime.Length - 1));
                    StartSeconds(seconds);
                }
                else if (type == 'm')
                {
                    minutes = int.Parse(inputTime.Substring(0, inputTime.Length - 1));
                    StartMinutes(minutes);
                }
                else
                {
                    Console.WriteLine("Invalid data type.");
                }

                Again();
            }
        }

        static void Menu()
        {
            ClearScreen();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Stopwatch".PadLeft(20 / 2 + "Stopwatch".Length / 2));
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Ex:  10m = 10 minutes");
            Console.WriteLine("Ex: 100s = 100 seconds");
            Console.Write("Set time: ");
        }

        static void StartSeconds(int seconds)
        {
            int hundredth;

            while (seconds != 0)
            {
                seconds--;
                hundredth = 100;
                ClearScreen();
                while (hundredth != 0)
                {
                    ClearScreen();
                    hundredth--;
                    Console.WriteLine($"{seconds}:{hundredth}");
                    Thread.Sleep(1);
                }
            }
            ClearScreen();
            Console.WriteLine("End...");
        }

        static void StartMinutes(int minutes)
        {
            int seconds = 0;
            int hundredth = 0;

            while (minutes != 0)
            {
                minutes--;
                ClearScreen();
                seconds = 60;
                while (seconds != 0)
                {
                    seconds--;
                    hundredth = 100;
                    while (hundredth != 0)
                    {
                        ClearScreen();
                        hundredth--;
                        Console.WriteLine($"{minutes}:{seconds}:{hundredth}");
                        Thread.Sleep(1);
                    }
                }

            }
            ClearScreen();
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
    
        static void ClearScreen()
        {
            try
            {
                Console.Clear();
            }
            catch (System.IO.IOException)
            {
                //ignore
            }
        }
    }
}