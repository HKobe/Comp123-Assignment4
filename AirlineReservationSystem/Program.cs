using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
            
    }
        #region  Airline Menu

        static public void ShowMenu()
        {
            int menuchoice = 0;
            while (menuchoice != 3)
            {

                Console.WriteLine("~~~~~~~Airline Reservation System~~~~~~~~~");
                Console.WriteLine("Please select your method of travel.");
                Console.WriteLine("        1. First Class");
                Console.WriteLine("        2. Seond Class");
                Console.WriteLine("        3. Exit");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("            Enter Choice : ");
                menuchoice = int.Parse(Console.ReadLine());

                switch (menuchoice)
                {
                    case 1:
                        Console.WriteLine("Seat 5");
                        break;
                    case 2:
                        Console.WriteLine("Seat 8");
                        break;
                    case 3:
                        break;                                        
                    default:
                        throw new ArgumentOutOfRangeException("Unknown value");
                }
            }
        }
        #endregion

    }
}
