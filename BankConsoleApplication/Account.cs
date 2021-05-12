using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApplication
{
    public class Account
    {
        string id;
        string name;
        string accountType;
        double amount;
        int pin;


        public Account()
        {

        }
        public Account(string id,string name,string accountype,double amount,int pin)
        {
            this.id = id;
            this.name = name;
            this.accountType = accountype;
            this.amount = amount;
            this.pin = pin;
        }

        public void TakeAccountDetailsFromUser()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("Enter the Account Number");
            id = Console.ReadLine();
            Console.WriteLine("*********************************");
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("*********************************");
            Console.WriteLine("Enter the Account Type");
            Accountype = Console.ReadLine();
            Console.WriteLine("*********************************");
            Console.WriteLine("Enter the New Account Pin");
            Pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*********************************");
            Console.WriteLine("Enter the Amount");
            amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*********************************");


        }

        public string Id { get => id; set => id = value; }
        public string Name { get=>name; set=>name=value; }
        public string Accountype { get=>accountType; set=>accountType=value; }

        public int Pin { get=>pin; set=>pin=value; }
        public double Amount { get=>amount; set=>amount=value; }

    }

}
