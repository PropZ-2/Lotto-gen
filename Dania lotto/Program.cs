using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dania_lotto
{
    class Program
    {
        static void Main(string[] args)
        {     
            // for loop counters
            int r;
            int j;
            int g;

            //min of max number på lotton
            int Min = 1;
            int Max = 37;

            //How many rows and tickets, and also yes or no to joker.
            DateTime today = DateTime.Now;
            Console.WriteLine("\tDagens dato: " + today.ToString("d"));
            Console.WriteLine("\tDania Lotto!");
            Console.WriteLine("Hvor mange raekker ville du have?");
            int rows = Convert.ToInt32(Console.ReadLine());

            //joker yes or no
            Console.WriteLine("ville du have jokertal med?\tskrive true = ja\tfalse = nej");
            bool jokerAnw = Convert.ToBoolean(Console.ReadLine());

            //amount of tickets
            Console.WriteLine("Hvor mange kuponer vil du have?");
            int Amount = Convert.ToInt32(Console.ReadLine());


            Console.Clear();



            Console.WriteLine("\tDagens dato:   " + today.ToString("d"));
            Console.WriteLine("\tDania Lotto!");

            //Generates generates and prints our numbers
            Random randNum = new Random();

            //main part of the program
            for (g = 0; g < Amount; ++g)
            {
                for (r = 0; r < rows; ++r)
                {
                    string tal = "";
                    for (j = 0; j < 7; ++j)
                    {
                        string num = "";
                        while (tal.Contains(num) || string.IsNullOrEmpty(num))
                        {
                            num = randNum.Next(Min, Max).ToString("D2");
                        }

                        tal += num + " ";

                        //tal += randNum.Next(Min, Max).ToString("D2") + " ";
                    }
                    Console.WriteLine((r + 1) + ": " + tal);
                }
                if (jokerAnw == true)
                {
                    //sets the numbers up for jokers
                    Min = 1;
                    Max = 10;
                    Console.WriteLine("******* Joker tal *******");
                    for (r = 1; r < 3; ++r)
                    {
                        string tal = "";
                        for (j = 0; j < 7; ++j)
                        {
                            tal += randNum.Next(Min, Max) + " ";
                        }
                        Console.WriteLine(r + ": " + tal);
                    }
                    //reset the numbers back to the defult
                    Min = 1;
                    Max = 37;
                }
                //here to make a space between each ticket for readablity
                Console.WriteLine("\n======= kupon number {0} =======", (g + 1));
                Console.WriteLine("---------------------------------------\n");
            }
            Console.ReadLine();
        }
    }
}
