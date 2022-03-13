using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssessment
{
    class GuestCheckOut
    {
        public void CheckOut(string[] arrayGR, int capacity)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Guest Check Out");
                Console.WriteLine("================");
                Console.Write($"Capsule #[1-{capacity}]: \n\n");
                int guestLeaveNum = int.Parse(Console.ReadLine());      //later TryParse
                int index = guestLeaveNum - 1;

                if (arrayGR[index] != null)
                {
                    Console.WriteLine("Success :)");
                    Console.WriteLine($"{arrayGR[index]} checked out from capsule #{guestLeaveNum}.");
                    arrayGR[index] = null;
                }
                else
                {
                    Console.WriteLine("Error :(");
                    Console.WriteLine($"Capsule #{guestLeaveNum} is unoccupied.");
                    isRunning = false;
                }
                Console.Write("Press any key to continue ");
                Console.ReadKey();
                Console.Clear();
                isRunning = false;
            }

        }
    }
}

