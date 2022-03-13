﻿using System;
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
                int capacitytest = GetPositiveInteger("Enter the number of capsules available: ");
                
                
                Console.WriteLine($"\nThere are {capacitytest} unoccupied capsules ready to be booked.");
                string[] arrayGR = new string[capacitytest];

                Console.Write("\n\nPress any key to continue ");
                Console.ReadKey();
                Console.Clear();
                Menu m = new Menu();
                m.Run(arrayGR,capacitytest);
            }
        public static int GetPositiveInteger(string prompt)
        {
            bool valid = false;
            int value;

            do
            {
                Console.Write(prompt);
                if (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("\nThat wasn't a number!\n");
                }
                else
                {
                    if (value > 0)
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("\nValue must be positive.\n");
                    }
                }
            } while (!valid);

            return value;
        }
    }
}
