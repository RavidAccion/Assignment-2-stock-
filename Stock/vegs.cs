using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    
        public class vegs
        {
         
            public void Tomato()
            {
                Console.WriteLine(" Want To Go To The Main Menu?");
                Console.WriteLine("****************");
                Console.WriteLine("Yes / No");
                string Data1 = Console.ReadLine();
                if (Data1 == "Yes")
                {
                    on();
                }
                else
                {
                    Console.WriteLine("ThankYou");
                }
            }
            public void on()
            {
                Console.WriteLine("************************");
                Console.WriteLine("Mobiles,Tablets,Laptops");
                string UserData1 = Console.ReadLine();
                if (UserData1 == "Tablets")
                {

                    Tomato();

                }
                else if (UserData1 == "Mobiles")
                {
                    on();
                }
              
                else
                {
                    Console.WriteLine("Enter a valid Input");
                }

            }
        }
}
