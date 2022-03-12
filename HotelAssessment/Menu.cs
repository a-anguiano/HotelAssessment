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
            //test Exit
            int capacity = 30; //test, lower capacity
            string[] arrayGR = new string[capacity];
            //testing for ViewGuests
            arrayGR[4] = "room 5 name";    //room 5, index 4
            arrayGR[6] = "room 7 name";
            arrayGR[29] = "room 30 name";

            //test check in
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("View Guests");
                Console.WriteLine("==============");
                Console.Write($"Capsule #[1-{capacity}]: ");
                int guestView = int.Parse(Console.ReadLine());

                int index = guestView;
                int low5 = index - 5;
                int high5 = index + 5;

                // +5 is over capacity  //capicity is index 29 in example
                //array.Length, index 0-29 = length of 30

                //if guestView not valid room number?
                //room to check is equal to zero or greater than capacity

                if (guestView > capacity || guestView <= 0)
                {
                        Console.WriteLine("Not a valid Capsale #.");
                }

                else if (high5 > capacity && low5 >= 0)       
                {
                    for (int i = low5; i < arrayGR.Length; i++)        //test
                    {
                        if (String.IsNullOrEmpty(arrayGR[i]))
                        {
                            arrayGR[i] = "[unoccupied]";
                        }

                        Console.WriteLine($"{i + 1}: {arrayGR[i]}");
                    }     
                }

                // -5 is less than zero
                else if (low5 < 0 && high5 < capacity)
                {
                    for (int i = 0; i <= high5; i++)
                    {
                        if (String.IsNullOrEmpty(arrayGR[i]))
                        {
                            arrayGR[i] = "[unoccupied]";
                        }

                        Console.WriteLine($"{i + 1}: {arrayGR[i]}");
                    }
                }


                else if (low5 > 0 && high5 <= capacity)         
                {
                    for (int i = low5; i <= high5-1; i++)       //capacity
                    {
                        if (String.IsNullOrEmpty(arrayGR[i]))
                        {
                            arrayGR[i] = "[unoccupied]";
                        }
                        Console.WriteLine($"{i + 1}: {arrayGR[i]}");
                    }
                }

                Console.Write("Press any key to continue ");
                Console.ReadKey();
                Console.Clear();
                isRunning = false;
            }
        }
    }
}
