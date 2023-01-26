using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class DrinkMachine
    {
        public int COST_OF_DRING = 150;
        public int COST_OF_PRODUCT = 0;
        public int RunningTotal { get; set; }

        public DrinkMachine()
        {
            RunningTotal = 0;
        }
        public void DepositCoin(int money)
        {
            switch (money)
            {
                case (5):
                    RunningTotal += 5;
                    break;
                case(10):
                    RunningTotal += 10;
                    break;
                case(25):
                    RunningTotal += 25;
                    break;
                case (100):
                    RunningTotal += 100;
                    break;
                default:
                    Console.WriteLine("Invalid Entry.");
                    break;

            }
        }
        public bool CheckTotal()
        {
            if (RunningTotal >= COST_OF_DRING)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayDrinkSelections()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("A-Cola");
            Console.WriteLine("B-Chips");
            Console.WriteLine("C- Candy");
            Console.WriteLine("*****************************");
            Console.WriteLine("Please make your selection");
            MakeDrinkSelection(Convert.ToChar(Console.ReadLine().ToUpper()));

        }
        private void MakeDrinkSelection(char selection)
        {
            bool selectionOK = false;
            while (!selectionOK)
            {
                switch(selection)
                {
                    case 'A':
                        COST_OF_PRODUCT = 100;
                        if (RunningTotal >=COST_OF_PRODUCT)
                        {
                            Console.WriteLine("Thank you for choosing a Cola");
                            selectionOK = true;
                            ReturnChange();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Money is not sufficient ");
                            break;

                        }

                    case 'B':
                        COST_OF_PRODUCT = 50;
                        if (RunningTotal >= COST_OF_PRODUCT)
                        {
                            Console.WriteLine("Thank you for choosing a Chips");
                            selectionOK = true;
                            ReturnChange();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Money is not sufficient ");
                            
                            break;

                        }

                    case 'C':
                        COST_OF_PRODUCT = 65;
                        if (RunningTotal >= COST_OF_PRODUCT)
                        {
                            Console.WriteLine("Thank you for choosing a Candy");
                            selectionOK = true;
                            COST_OF_PRODUCT = 65;
                            ReturnChange();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Money is not sufficient ");

                            break;

                        }
                    default:
                        Console.WriteLine("Invalid Selection. Please re-enter your selection: ");
                        selection = Convert.ToChar(Console.ReadLine().ToUpper());
                        selectionOK = false;
                        break;
                }
            }

        }
        private void ReturnChange()
        {
            if (RunningTotal > COST_OF_PRODUCT)
            {
                Console.WriteLine("Your change is $ {0}", (RunningTotal - COST_OF_PRODUCT) * 0.01);
            }
        }
    }
}
