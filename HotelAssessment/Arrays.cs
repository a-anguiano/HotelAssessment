using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssessment
{
    class Arrays
    {
        public static void inArray()    //string[]?
        {
            string[] arrayGR = new string[StartUp.Initial()];           //hmmmmmm what if Check I isn't first option
            Menu s = new Menu();
            //s.CheckIn();
            //is room available
            //search for newRoom
            //index begins at 0
            string GR = s.CheckIn();
            int commaIndex = GR.IndexOf(",");
            string newRoom = GR.Substring(0, commaIndex - 1);
            string newGuest = GR.Substring(commaIndex, GR.Length - 1);      //length too long
            int newNumRoom = int.Parse(newRoom);

            if (arrayGR[newNumRoom] == null)
            {
                //success
                Console.WriteLine("Success :)");
                Console.WriteLine($"{newGuest} is booked in capsule #{newRoom}.");
                arrayGR[newNumRoom] = GR;
            }
            else
            {
                Console.WriteLine("Error :(");
                Console.WriteLine($"Capsule #{newRoom} is occupied.");
                //another roomnum?
            }
            //return arrayGR;
        }
    }
}
