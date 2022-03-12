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

            GuestList g = new GuestList();
            g.ViewGuest();
        }
    }
}
