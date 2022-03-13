using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssessment
{
    class GuestList
    {
        public void ViewGuest(string[] arrayGR, int capacity)
        {           
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("View Guests");
                Console.WriteLine("==============");
                Console.Write($"Capsule #[1-{capacity}]: ");
                int guestView = int.Parse(Console.ReadLine());

                //need to handle non-existing room number, out of bounds basically

                int low5 = guestView - 5;
                int high5 = guestView + 5;
                string[] guestViewArray = arrayGR;

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
                            guestViewArray[i] = "[unoccupied]";
                            Console.WriteLine($"{i + 1}: {guestViewArray[i]}");
                            guestViewArray[i] = null;
                        }
                        else
                        {
                            Console.WriteLine($"{i + 1}: {guestViewArray[i]}");
                        }
                    }
                }

                else if (low5 < 0)
                {
                    for (int i = 0; i < high5; i++)
                    {
                        if (String.IsNullOrEmpty(arrayGR[i]))
                        {
                            guestViewArray[i] = "[unoccupied]";
                            Console.WriteLine($"{i + 1}: {guestViewArray[i]}");
                            guestViewArray[i] = null;
                        }
                        else
                        {
                            Console.WriteLine($"{i + 1}: {guestViewArray[i]}");
                        }
                    }
                }

                else if (low5 == 0 && high5 <= capacity)  
                {
                    for (int i = low5; i < high5; i++)      
                    {
                        if (String.IsNullOrEmpty(arrayGR[i]))
                        {
                            guestViewArray[i] = "[unoccupied]";
                            Console.WriteLine($"{i + 1}: {guestViewArray[i]}");
                            guestViewArray[i] = null;
                        }
                        else
                        {
                            Console.WriteLine($"{i + 1}: {guestViewArray[i]}");
                        }
                    }
                }

                else if (low5 > 0 && high5 <= capacity) 
                {
                    for (int i = low5-1; i < high5; i++)       
                    {
                        if (String.IsNullOrEmpty(arrayGR[i]))
                        {
                            guestViewArray[i] = "[unoccupied]";
                            Console.WriteLine($"{i + 1}: {guestViewArray[i]}");
                            guestViewArray[i] = null;
                        }
                        else
                        {
                            Console.WriteLine($"{i + 1}: {guestViewArray[i]}");
                        }
                        
                    }
                }

                Console.Write("\n\nPress any key to continue ");
                Console.ReadKey();
                Console.Clear();
                isRunning = false;
            }
        }
    }
}
