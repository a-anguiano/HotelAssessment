using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssessment
{
    class GuestList
    {
        public void ViewGuest(int capacity)
        {
            Console.Clear();
            
            //int capacity = 30; //test
            string[] arrayGR = new string[capacity];
            //testing for ViewGuests
            arrayGR[4] = "room 5 name";    //room 5, index 4
            arrayGR[6] = "room 7 name";
            arrayGR[29] = "room 30 name";

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("View Guests");
                Console.WriteLine("==============");
                Console.Write($"Capsule #[1-{capacity}]: ");
                int guestView = int.Parse(Console.ReadLine());

                int low5 = guestView - 5;
                int high5 = guestView + 5;

                if (guestView > capacity || guestView <= 0)
                {
                    Console.WriteLine("Not a valid Capsale #.");
                }

                else if (high5 > capacity)  
                {
                    for (int i = low5-1; i < arrayGR.Length; i++)    
                    {
                        if (String.IsNullOrEmpty(arrayGR[i]))
                        {
                            arrayGR[i] = "[unoccupied]";
                        }
                        Console.WriteLine($"{i + 1}: {arrayGR[i]}");
                    }
                }

                else if (low5 < 0)
                {
                    for (int i = 0; i < high5; i++)
                    {
                        if (String.IsNullOrEmpty(arrayGR[i]))
                        {
                            arrayGR[i] = "[unoccupied]";
                        }

                        Console.WriteLine($"{i + 1}: {arrayGR[i]}");
                    }
                }

                else if (low5 == 0 && high5 <= capacity)  
                {
                    for (int i = low5; i < high5; i++)      
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
                    for (int i = low5-1; i < high5; i++)       
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
