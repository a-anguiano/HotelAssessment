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

        public void Run()
        {
            //need to fix this set-up
            bool initial = true;
            while (initial)
            {
                Console.WriteLine("Welcome to Capsule-Capsule");
                Console.WriteLine("==========================");
                Console.Write("Enter the number of capsules available: ");
                //
                int capacitytest = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nThere are {capacitytest} unoccupied capsules ready to be booked.");

                Console.Write("\n\nPress any key to continue ");
                Console.ReadKey();
                Console.Clear();
                initial = false;
            }

            //test
            int capacity = 30;
            string[] guestAndRoom = new string[capacity];
            guestAndRoom[4] = "room 5 name";    //room 5, index 4
            guestAndRoom[6] = "room 7 name";
            guestAndRoom[29] = "room 30 name";

            Console.Clear();
            bool running = true;

            while (running)
            {
                string choice = BuildMenu().ToUpper();

                switch (choice)
                {
                    case checkIn:
                        GuestCheckIn i = new GuestCheckIn();
                        i.CheckIn(guestAndRoom, capacity);
                        break;
                    case checkOut:
                        GuestCheckOut o = new GuestCheckOut();
                        o.CheckOut(guestAndRoom, capacity);
                        break;
                    case viewGuests:
                        GuestList g = new GuestList();
                        g.ViewGuest(capacity);      
                        break;
                    case exit:
                        Exit e = new Exit();
                        e.ExitProgram();
                        break;
                        default:
                        HandleUnknownInput();
                        break;
                }
            }
        }
        
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
    private void HandleUnknownInput()
    {
            Console.WriteLine("Wrong");         //adapt to request valid input, maybe not needed right now
    }
    }
}
