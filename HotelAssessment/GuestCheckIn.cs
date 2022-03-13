using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssessment
{
    class GuestCheckIn
    {
        public void CheckIn(string[] guestsArray, int capacity)
        {
            bool isRunning = true;

            while (isRunning)
            {               
                Console.WriteLine("Guest Check In");
                Console.WriteLine("==============");
                Console.Write("Guest Name: ");
                string newGuest = Console.ReadLine();
                int newRoom = GuestList.EnterRoomNumber($"Capsule #[1-{capacity}]: ", capacity);
                int i = newRoom - 1;

                if (String.IsNullOrEmpty(guestsArray[i]))
                {
                    Console.WriteLine("\n\nSuccess :)");
                    Console.WriteLine($"{newGuest} is booked in capsule #{newRoom}.");
                    guestsArray[i] = newGuest;
                    Console.Write("Press any key to continue ");
                    Console.ReadKey();
                    Console.Clear();
                    isRunning = false;
                }                                                               
                else
                {
                    Console.WriteLine("\n\nError :(");
                    Console.WriteLine($"Capsule #{newRoom} is occupied.\n\n");
                } 
            }
        }
    }
}
