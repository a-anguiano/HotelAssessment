using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssessment
{
    class Menu
    {
        private const string checkIn = "1";
        private const string checkOut = "2";
        private const string viewGuests = "3";
        private const string exit = "4";

        int capacity = StartUp.Initial();       //how to use capacity everywhere
        int i = 0;
        private string[] CreateArray()
        {
            if (i == 0)
            {
                string[] arrayGR = new string[capacity];
                i++;
                return arrayGR;
            }
            else
            {
                string[] arrayGR = CheckIn();
                return arrayGR;
            }
        }

        public void Run()
        {
            Console.Clear();
            bool running = true;

            while (running)
            {
                string choice = BuildMenu();    //.ToUpper()

                switch (choice)
                {
                    case checkIn:
                        CheckIn();  //CheckIn(guestAndRoom)
                        break;
                    case checkOut:
                        CheckOut();         //see 
                        break;
                    case viewGuests:
                        ViewGuests();       //see
                        break;
                    case exit:
                        //Exit();
                        running = false;    //move to exit
                        break;
                    default:
                        HandleUnknownInput();
                        break;
                }
            }
        }
        private void ViewGuests() //private void ViewGuests(string[] currentGR)
        {
            Console.Clear();
            Console.WriteLine("View Guests");
            Console.WriteLine("==============");
            Console.Write($"Capsule #[1-{capacity}]: ");
            string guestView = Console.ReadLine();
            Console.WriteLine("\nCapsule: Guest");
            Console.WriteLine($"{guestView}");
            Console.WriteLine("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
        }

        private string[] CheckIn()
        {
            string[] arrayGR = CreateArray();        //not sure

            //cosider moving the asking for a task into another method
            Console.Clear();
            
            Console.WriteLine("Guest Check In");
            Console.WriteLine("==============");
            Console.Write("Guest Name: ");
            string newGuest = Console.ReadLine();
            Console.Write($"Capsule #[1-{capacity}]: ");
            int newRoom = int.Parse(Console.ReadLine());
            int i = newRoom - 1;
                       //hmmmmmm what if Check I isn't first option

                if (arrayGR[i] != null)
                {
                Console.WriteLine("Error :(");
                Console.WriteLine($"Capsule #{newRoom} is occupied.");
                }                                                               //update arrayGR
                else
                {
                Console.WriteLine("Success :)");
                Console.WriteLine($"{newGuest} is booked in capsule #{newRoom}.");
                arrayGR[i] = newGuest;
                Console.WriteLine($"{arrayGR[i]}");
                }

            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
            return arrayGR;
        }   //private string[] CheckIn(string[] currentGR)

        private void CheckOut()
        {
            Console.Clear();
            Console.WriteLine("Guest Check Out");
            Console.WriteLine("================");
            Console.Write($"Capsule #[1-{capacity}]: ");
            string guestLeaveNum = Console.ReadLine();

            //success statement
            Console.WriteLine("Success :)");
            Console.WriteLine($"NAME checked out from capsule #{guestLeaveNum}.");  //interpolation, fix cuz null

            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
        }

        //private bool Exit(bool r)
        //{
        //    //ToUpper
        //    r = false;
        //    return r;
        //}

        private void HandleUnknownInput()
        {
            Console.WriteLine("Wrong");         //adapt to request valid input, maybe not needed right now
        }       //may not be needed

        private string BuildMenu()
        {
            Console.WriteLine("Guest Menu");
            Console.WriteLine("==========================");
            Console.WriteLine($"{checkIn}: Check In");
            Console.WriteLine($"{checkOut}: Check Out");
            Console.WriteLine($"{viewGuests}: View Guests");
            Console.WriteLine($"{exit}: Exit\n");
            Console.Write("Choose option [1-4]: ");
            return Console.ReadLine();
        }

    }
}
