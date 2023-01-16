using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public  class Groceries : vegs
    {
        public void tostart()
        {
            Console.WriteLine(" Want To Go To The Main Menu?");
            Console.WriteLine("****************");
            Console.WriteLine("Yes / No");
            string Data1 = Console.ReadLine();
            if (Data1 == "Yes") {
                elec1();
            }
            else
            {
                Console.WriteLine("ThankYou");
            }
        }
    
        public void elec1()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Batters,Coffee,Rice");
            string UserData1 = Console.ReadLine();
            if (UserData1 == "Batters")
            {

                Batters();

            }
            else if (UserData1 == "Coffee")
            {
                Coffee();
            }
            else if (UserData1 == "Rice")
            {
                Rice();
            }
            else
            {
                Console.WriteLine("Enter a valid Input");
            }

        }
        public void Coffee()
        {

            int avail = 35;
            int sold = 235;
            int total = avail + sold;
            Console.WriteLine("Available / Sold /Total ?");
            string a1 = Console.ReadLine();

            if (a1 == "Sold")
            {
                Console.WriteLine(avail + " packs of HAs Been Sold");
            }
            else if (a1 == "Available")
            {
                Console.WriteLine(sold + "packs of Coffee Available");
            }
            else if (a1 == "Total")
            {
                Console.WriteLine("Total Coffee Packs" + total);
            }
            else
            {
                Console.WriteLine("enter a valid Input");
            }

            tostart();


        }
        public void Batters()
        {
            int avail = 32;
            int sold = 21;
            int total = avail + sold;
            Console.WriteLine("Available / Sold /Total ?");
            string a = Console.ReadLine();
            if (a == "Sold")
            {
                Console.WriteLine(sold+"KG" + "  Has Been Sold");
            }
            else if (a == "Available")
            {
                Console.WriteLine(avail + "KG" + "  Available");
            }
            else if (a == "Total")
            {
                Console.WriteLine("Total " + "KG"  + "" + total);
            }
            else
            {
                Console.WriteLine("enter a valid Input");
            }

            tostart();

        }

        public void Rice()
        {
            int avail = 15;
            int sold = 495;
            int total = avail + sold;
            Console.WriteLine("Available / Sold /Total ?");
            string a = Console.ReadLine();
            if (a == "Sold")
            {
                Console.WriteLine(sold + "KG Rice Has Been Sold");
            }
            else if (a == "Available")
            {
                Console.WriteLine(avail + "KG Rice Available");
            }
            else if (a == "Total")
            {
                Console.WriteLine("Total Rice" + "" + total+"KG");
            }
            else
            {
                Console.WriteLine("enter a valid Input");
            }

            tostart();
        }
    }
}
