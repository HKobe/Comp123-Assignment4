using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Hassan Kobeissi
 * Created July 7th, 2016
 * Modified on July 7th, 2016
 * Program intended to display dice rolls and tallies.
 */
namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dice 
            ///Psuedo Number Objbect
            Random random = new Random();
             ///New List named diceRolls of type int
            List<int> diceRolls = new List<int>();

            int[] tally = new int[13];
            ///Maximum number of rolls
            int maxRolls = 36000;


            //builds the list 
            for (int index = 0; index < maxRolls; index++)
            {
                ///Dice One = Random Rolls from 1-6
                int firstDie = random.Next(1, 7);
                int secondDie = random.Next(1, 7);
                ///Sum of the two values
                int dice = firstDie + secondDie;
                /// the sum in place and incremented in a tally
                tally[dice]++;
                diceRolls.Add(dice);
            }

            ///Sorts List
            diceRolls.Sort();


            // display list 
            /* 
            foreach (int result in diceRolls) 
            { 
                Console.Write(result + " "); 
            } 
            Console.WriteLine(); 
            */

            //A minimum of two can be rolled
            for (int index = 2; index < 13; index++)
            {
                Console.WriteLine("Roll # {0} was rolled {1} times.", index, tally[index]);
            }
            #endregion           
            Console.WriteLine();
            ShowMenu();       
            }

        #region  Airline Menu

        static public int ShowMenu()
        {
            Console.WriteLine(" THANK YOUR FOR FLYING AIRCANADA");
            Console.WriteLine("=================================");
            Console.WriteLine("    Enter 1 for First Class   ");
            Console.WriteLine("    Enter 2 for Economy       ");
            Console.WriteLine("    Enter 3 to Exit Menu      ");
            Console.WriteLine("=================================");
                Console.Write("     Enter Your Option : ");
            var userInput = Console.ReadLine();
            try
            {

            }
            catch
            {

            }
            return Convert.ToInt32(userInput);
            #endregion

            /*string choice = "x";
           switch (choice)
           {
               case "1":
                   Console.WriteLine("First Class");
                   break;
               case "2":
                   Console.WriteLine("Econonmy");
                   break;
               case "3":
                   Console.WriteLine("Exit");
                   break;
               default:
                   Console.WriteLine("Error");
                   break;*/


        }
    }
       

        }

