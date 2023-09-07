using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dessert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dessert_Choice();
            Console.ReadKey();
        }
        static void Dessert_Choice()
        {
            Console.WriteLine("Would you like some dessert? ");


            if string("yes")
            {
                Console.WriteLine("Awsome. I'll grab you a dessert menu");
                Console.ReadKey();
            }

            else if ("no")
            {
                Console.WriteLine("No Worries. I'll grab you the check");
                Console.ReadKey();
            }
        }
    }
}
