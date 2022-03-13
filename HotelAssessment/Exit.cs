using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssessment
{
    class Exit
    {
        public void ExitProgram(string[] guestsArray, int capacity)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Exit");
                Console.WriteLine("=========");
                Console.WriteLine("Are you sure you want to exit?");
                Console.WriteLine("All data will be lost");
                Console.Write("Exit [y/n]: ");
                string response = Console.ReadLine().ToLower();

                if (response == "y")
                {
                    Console.WriteLine("\n\nGoodbye!");
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Menu m = new Menu();
                    m.Run(guestsArray, capacity);
                }
            }
        }
    }
}
