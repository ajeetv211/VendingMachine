using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var DrinkMachine = new DrinkMachine();
            while (!DrinkMachine.CheckTotal())
            {
                Console.WriteLine("Please enter coin or dollar bill (5, 10, 25, 100)");
                DrinkMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));

                
                
            }
            DrinkMachine.DisplayDrinkSelections();

            Console.ReadLine();
        }
    }
}
