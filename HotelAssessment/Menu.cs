using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssessment
{
    class Menu
    {
        public void Run()
        {
            int capacity = 30; //test, lower capacity
            string[] arrayGR = new string[capacity];
            //testing for ViewGuests
            arrayGR[4] = "room 5 name";    //room 5, index 4
            arrayGR[6] = "room 7 name";

            //test check in
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("View Guests");
                Console.WriteLine("==============");
                Console.Write($"Capsule #[1-{capacity}]: ");
                int guestView = int.Parse(Console.ReadLine());
                Console.WriteLine($"View Guests {guestView}");

                int index = guestView - 1;
                int low5 = index - 5;
                int high5 = index + 5;

                for (int i = low5; i <= high5; i++)
                {
                    if (String.IsNullOrEmpty(arrayGR[i]))
                    {
                        arrayGR[i] = "[unoccupied]";
                    }

                    Console.WriteLine($"{i+1}: {arrayGR[i]}");
                }

                Console.Write("Press any key to continue ");
                Console.ReadKey();
                Console.Clear();
                isRunning = false;
            }
        }
    }
}
