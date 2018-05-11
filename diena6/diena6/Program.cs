using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diena6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Ievadi savu laimigo skaitli***");
            string ievads = Console.ReadLine();
            Console.WriteLine(Ievadaskaitli(ievads));
            Console.ReadLine();
        }
        static string Ievadaskaitli(string skaitlis)

        {


            string rezultats = "Tavs laimigais skaitlis ir ----->  " + skaitlis;

            return rezultats;
        }
    }
    
    

}





