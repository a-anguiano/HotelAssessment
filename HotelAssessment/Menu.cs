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

        public void Run(string[] guestsArray, int capacity)
        {
            Console.Clear();
            bool running = true;

            while (running)
            {
                string choice = BuildMenu().ToUpper();

                switch (choice)
                {
                    case checkIn:
                        Console.Clear();
                        GuestCheckIn i = new GuestCheckIn();
                        i.CheckIn(guestsArray, capacity);
                        break;
                    case checkOut:
                        Console.Clear();
                        GuestCheckOut o = new GuestCheckOut();
                        o.CheckOut(guestsArray, capacity);
                        break;
                    case viewGuests:
                        Console.Clear();
                        GuestList g = new GuestList();
                        g.ViewGuest(guestsArray, capacity);      
                        break;
                    case exit:
                        Console.Clear();
                        Exit e = new Exit();
                        e.ExitProgram(guestsArray, capacity);
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
            Console.WriteLine("\n\nNot a valid input. Please select [1-4]");
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
    }
    }
}
