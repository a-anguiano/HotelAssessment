using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssessment
{
    class StartUp
    {
        public static int Initial()
        {
            Console.WriteLine("Welcome to Capsule-Capsule");
            Console.WriteLine("==========================");
            Console.Write("Enter the number of capsules available: ");
            int capacity = int.Parse(Console.ReadLine());
            Console.WriteLine($"There are {capacity} unoccupied capsules ready to be booked.");
            return capacity;
        }
    }
}
