using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a switch block

            Console.WriteLine("Coffee Sizes: 1=Small 2=Medium 3=Large");
            Console.Write("Please enter your selection:");
            string str = Console.ReadLine();
            int cost = 0;

            switch (str)
            {
                case "1":
                case "small":
                    cost += 25;
                    break;
                case "2":
                case "medium":
                    cost += 50;
                    break;
                case "3":
                case "large":
                    cost += 75;
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents", cost);
                    }
            Console.WriteLine("Thank you for your business!");
        }
    }
}
