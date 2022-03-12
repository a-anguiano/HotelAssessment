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
            //testing for CheckOut
            arrayGR[4] = "name";    //room 5, index 4

            //test check in
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Guest Check Out");
                Console.WriteLine("================");
                Console.Write($"Capsule #[1-{capacity}]: ");
                int guestLeaveNum = int.Parse(Console.ReadLine());
                int index = guestLeaveNum - 1;

                if(arrayGR[index] != null)
                {
                    //success statement
                    Console.WriteLine("Success :)");
                    Console.WriteLine($"{arrayGR[index]} checked out from capsule #{guestLeaveNum}.");
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
            }
        }
    }
}
