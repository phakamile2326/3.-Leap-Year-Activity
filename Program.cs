using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Leap_Year_Activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leap_year;
            Console.WriteLine("\n\n");
            Console.WriteLine("check whether a given year is a leap year or not?");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine(" Enter a year");
  

            leap_year = Convert.ToInt32(Console.ReadLine());
            if ((leap_year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n ", leap_year);
            else if ((leap_year % 100) == 0)
                Console.WriteLine("{0} is not a leap year. \n", leap_year);
            else if ((leap_year % 4) == 0)
                Console.WriteLine("{0} is a leap year. \n", leap_year);
            else
                Console.WriteLine("{0} is not a leap year.");

            Console.ReadLine();

        }
    }
}
