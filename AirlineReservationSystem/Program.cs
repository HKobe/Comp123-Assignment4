using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Hassan Kobeissi 
 * Created: 2016-07-07 
 * Modified: 2016-07-07
 * Purpose: Assign seats on each flight of the airline's only plane.
 */
namespace AirlineReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Displays ShowMenu() method
            ShowMenu();

            #region seatingChart
            ///List carries all seats
            List<string> seatingChart = new List<string>();
            seatingChart.Add("Seat 1");
            seatingChart.Add("Seat 2");
            seatingChart.Add("Seat 3");
            seatingChart.Add("Seat 4");
            seatingChart.Add("Seat 5");
            seatingChart.Add("Seat 6");
            seatingChart.Add("Seat 7");
            seatingChart.Add("Seat 8");
            seatingChart.Add("Seat 9");
            seatingChart.Add("Seat 10");
            for (int s = 0; i < length; i++)
            {

            }

            #endregion

            #region Assigned Seats
            ///Assigned Seats List
            List<string> assignedSeats = new List<string>();
            assignedSeats.Add("Seat 1 Assigned");
            assignedSeats.Add("Seat 3 Assigned");
            assignedSeats.Add("Seat 7 Assigned");
            assignedSeats.Add("Seat 10 Assigned");
            assignedSeats.Add("Seat  Assigned");
            for (int i = 0; i < assignedSeats.Count; i++)
            {
                if (assignedSeats.Contains("Seat " + (i + 1)))
                    continue;
                else
                {
                    assignedSeats.Add("Seat " + (i + 1));
                }


            }

            #endregion
            ///Remove the seat from the chart list
            seatingChart.RemoveAt(0);

        }
        #region  Airline Menu
        /// <summary>
        /// Displays option menu for first second or exit
        /// </summary>
        static public void ShowMenu()
        {
            int menuchoice = 0;
            while (menuchoice != 3)
            {

                Console.WriteLine("~~~~~~~Airline Reservation System~~~~~~~~~");
                Console.WriteLine("Please select your method of travel.");
                Console.WriteLine("        1. First Class");
                Console.WriteLine("        2. Second Class");
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
