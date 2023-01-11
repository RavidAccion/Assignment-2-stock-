using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
   public  class Electronics : Groceries
    {
        Groceries obj2 = new Groceries();
        public void tostart1()
        {
            Console.WriteLine(" Want To Go To The Main Menu?");
            Console.WriteLine("****************");
            Console.WriteLine("Yes / No");
            string Data1 = Console.ReadLine();
            if (Data1 == "Yes")
            {
                elec();
            }
            else
            {
                Console.WriteLine("ThankYou");
            }
        }
        public void elec()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Mobiles,Tablets,Laptops");
            string UserData1 = Console.ReadLine();
            if (UserData1 == "Tablets")
            {

                Tablet();

            }else if(UserData1 == "Mobiles")
            {
                Mobile();
            }else if(UserData1 == "Laptops")
            {
                Laptops();
            }
            else
            {
                Console.WriteLine("Enter a valid Input");
            }
           
        }
        public void Mobile( ) {
           
            int avail = 35;
            int sold = 235;
            int total = avail + sold;
            Console.WriteLine("Available / Sold /Total ?");
            string a1 = Console.ReadLine();
           
            if (a1 == "Sold")
            {
                Console.WriteLine(avail + " Mobile Has Been Sold");
            } 
              else if (a1 == "Available")
            {
                Console.WriteLine(sold + " Mobiles Available");
            }
              else if (a1 == "Total")
            {
                Console.WriteLine("Total mobiles"+""+ total);
            }
              else
            {
                Console.WriteLine("enter a valid Input");
            }

            tostart1();



        }
        public void Tablet()
        {
            int avail = 315;
            int sold = 25;
            int total = avail + sold;
            Console.WriteLine("Available / Sold /Total ?");
            string a = Console.ReadLine();
            if (a == "Sold")
            {
                Console.WriteLine(sold + " Tablet Has Been Sold");
            }
            else if (a == "Available")
            {
                Console.WriteLine(avail + " Tablet Available");
            }
            else if (a == "Total")
            {
                Console.WriteLine("Total Tablet" +""+ total);
            }
            else
            {
                Console.WriteLine("enter a valid Input");
            }

            tostart1();

        }
    
        public void Laptops()
        {
            int avail = 15;
            int sold = 45;
            int total = avail + sold;
            Console.WriteLine("Available / Sold /Total ?");
            string a = Console.ReadLine();
            if (a == "Sold")
            {
                Console.WriteLine(sold + " Laptops Has Been Sold");
            }
            else if (a == "Available")
            {
                Console.WriteLine(avail + " Laptops Available");
            }
            else if (a == "Total")
            {
                Console.WriteLine("Total Laptops" + "" + total);
            }
            else
            {
                Console.WriteLine("enter a valid Input");
            }

           tostart1();
        }
    }
}
