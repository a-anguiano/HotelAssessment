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

        public static int Initial()
        {
            Console.WriteLine("Welcome to Capsule-Capsule");
            Console.WriteLine("==========================");
            Console.Write("Enter the number of capsules available: ");
            int capacity = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nThere are {capacity} unoccupied capsules ready to be booked.");

            Console.Write("\n\nPress any key to continue ");
            Console.ReadKey();
            Console.Clear();
            return capacity;
        }
        public void Run()
        {
            //string[] guestAndRoom = new string[capacity];
            //bool initial = true;
            //while(initial)
            //{
            //    Console.WriteLine("Welcome to Capsule-Capsule");
            //    Console.WriteLine("==========================");
            //    Console.Write("Enter the number of capsules available: ");
            //    int capacity = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"\nThere are {capacity} unoccupied capsules ready to be booked.");

            //    Console.Write("\n\nPress any key to continue ");
            //    Console.ReadKey();
            //    Console.Clear();
            //    initial = false;
            //}

            Console.Clear();
            bool running = true;

            while (running)
            {
                string choice = BuildMenu().ToUpper();

                switch (choice)
                {
                    case checkIn:
                        //CheckIn();  //CheckIn(guestAndRoom)
                        break;
                    case checkOut:
                        //CheckOut();         //see 
                        break;
                    case viewGuests:
                        int capacity = Initial();
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
