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
                                //int capacity = StartUp.Initial();
                                //string[] guestAndRoom = new string[capacity];

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
                        GuestList g = new GuestList();
                        g.ViewGuest();      //see
                        break;
                    case exit:
                        //Exit();
                        Exit e = new Exit();
                        running = e.ExitProgram();
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
