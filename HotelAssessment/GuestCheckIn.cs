using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssessment
{
    class GuestCheckIn
    {
        public void CheckIn(string[] arrayGR, int capacity)
        {

            //test check in
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Guest Check In");
                Console.WriteLine("==============");
                Console.Write("Guest Name: ");
                string newGuest = Console.ReadLine();
                Console.Write($"Capsule #[1-{capacity}]: ");
                int newRoom = int.Parse(Console.ReadLine());
                int i = newRoom - 1;
                //hmmmmmm what if Check I isn't first option

                if (arrayGR[i] != null)
                {
                    Console.WriteLine("Error :(");
                    Console.WriteLine($"Capsule #{newRoom} is occupied.");
                    isRunning = false;
                }                                                               //update arrayGR
                else
                {
                    Console.WriteLine("Success :)");
                    Console.WriteLine($"{newGuest} is booked in capsule #{newRoom}.");
                    arrayGR[i] = newGuest;
                    Console.WriteLine($"{arrayGR[i]}");
                }

                Console.Write("Press any key to continue ");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
