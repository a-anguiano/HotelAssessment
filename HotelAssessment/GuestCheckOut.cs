using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssessment
{
    class GuestCheckOut
    {
        public void CheckOut(string[] guestsArray, int capacity)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Guest Check Out");
                Console.WriteLine("================");
                int guestLeaveNum = GuestList.EnterRoomNumber($"Capsule #[1-{capacity}]: ", capacity);     
                int index = guestLeaveNum - 1;

                if (!String.IsNullOrEmpty(guestsArray[index]))
                {
                    Console.WriteLine("\n\nSuccess :)");
                    Console.WriteLine($"{guestsArray[index]} checked out from capsule #{guestLeaveNum}.");
                    guestsArray[index] = null;
                    Console.Write("Press any key to continue ");
                    Console.ReadKey();
                    Console.Clear();
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("\n\nError :(");
                    Console.WriteLine($"Capsule #{guestLeaveNum} is unoccupied.\n\n");
                }
                
            }

        }
    }
}

