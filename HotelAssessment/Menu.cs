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
                        CheckInArray();  //CheckIn(guestAndRoom)
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

        void CheckInArray()    //string[]?
        {
            string[] arrayGR = new string[capacity];           //hmmmmmm what if Check I isn't first option
            string GR = CheckIn();
            int commaIndex = GR.IndexOf(",");
            string newRoom = GR.Substring(0, commaIndex - 1);
            string newGuest = GR.Substring(commaIndex, GR.Length - 1);      //length too long
            int newNumRoom = int.Parse(newRoom);

            if (arrayGR[newNumRoom] == null)
            {
                Console.WriteLine("Success :)");
                Console.WriteLine($"{newGuest} is booked in capsule #{newRoom}.");
                arrayGR[newNumRoom] = GR;
            }
            else
            {
                Console.WriteLine("Error :(");
                Console.WriteLine($"Capsule #{newRoom} is occupied.");
            }
            Console.Write("Press any key to continue ");

            Console.ReadKey();
            Console.Clear();
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

        public string CheckIn()
        {
            //cosider moving the asking for a task into another method
            Console.Clear();
            
            Console.WriteLine("Guest Check In");
            Console.WriteLine("==============");
            Console.Write("Guest Name: ");
            string newGuest = Console.ReadLine();
            Console.Write($"Capsule #[1-{capacity}]: ");
            string newRoom = Console.ReadLine();

            string GR = newRoom + "," + newGuest;
            return GR;
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
