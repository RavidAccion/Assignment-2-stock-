
using Stock;
using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

class Program : Electronics

{
    public static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO STOCK CHECK.COM");
        Console.WriteLine("Enter Any Product Which You want To know The Details");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("Groceries / Electronics");
       
        string UserData = Console.ReadLine();

        Electronics obj1= new Electronics();
       if(UserData == "Electronics") {

            obj1.elec();

        }
        else if (UserData == "Groceries")
        {

            obj1.elec1();

        }


    }
}