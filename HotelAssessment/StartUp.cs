using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssessment
{
    class StartUp
    {
            public void Initial()
            {
                Console.WriteLine("Welcome to Capsule-Capsule");
                Console.WriteLine("==========================");
                Console.Write("Enter the number of capsules available: ");
                
                int capacitytest = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nThere are {capacitytest} unoccupied capsules ready to be booked.");
                string[] arrayGR = new string[capacitytest];

                Console.Write("\n\nPress any key to continue ");
                Console.ReadKey();
                Console.Clear();
                Menu m = new Menu();
                m.Run(arrayGR,capacitytest);
        }
    }
}
