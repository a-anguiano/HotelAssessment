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

        public void Run(string[] guestAndRoom, int capacity)
        {
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
                        g.ViewGuest(guestAndRoom, capacity);      
                        break;
                    case exit:
                        Exit e = new Exit();
                        e.ExitProgram(guestAndRoom, capacity);
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
            Console.WriteLine("\n\nWrong");         //adapt to request valid input, maybe not needed right now
    }
    }
}
