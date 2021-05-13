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
            int idcounter = 0;
            while (idcounter == 0)
            {
                Console.WriteLine("Enter the Account Number");
                id = Console.ReadLine();
                if (string.IsNullOrEmpty(id))
                {
                    Console.WriteLine("Account Number cannot be empty!");
                }
                else
                    idcounter = 1;

            }
            Console.WriteLine("*********************************");

            int namecounter = 0;
            while (namecounter == 0)
            { 
                Console.WriteLine("Enter Name");
                name= Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name cannot be empty!");
                }
                else
                    namecounter = 1;

            }
            
            Console.WriteLine("*********************************");

            int acctypecounter = 0;
            while (acctypecounter == 0)
            {
                Console.WriteLine("Enter the Account Type");
                Accountype = Console.ReadLine();
                if (string.IsNullOrEmpty(Accountype))
                {
                    Console.WriteLine("Accounttype cannot be empty!");
                }
                else
                    acctypecounter = 1;

            }
           
            Console.WriteLine("*********************************");


            int pincounter = 0;
            while (pincounter == 0)
            {
                Console.WriteLine("Enter the New Account Pin");
                Pin = Convert.ToInt32(Console.ReadLine());

                if (Pin==default(int))
                {
                    Console.WriteLine("Pin cannot be empty and length should be exact 4 numbers!");
                }
                else
                    pincounter = 1;

            }
            
            Console.WriteLine("*********************************");

            int accountcounter = 0;
            while (accountcounter == 0)
            {
                Console.WriteLine("Enter the Amount");
                amount = Convert.ToDouble(Console.ReadLine());
                var amountAsString = acctypecounter.ToString();
                if (string.IsNullOrEmpty(amountAsString))
                {
                    Console.WriteLine("Amount cannot be empty!");
                }
                else
                    accountcounter = 1;

            }
            
            Console.WriteLine("*********************************");


        }
        public string Id { get => id; set => id = value; }
        public string Name { get=>name; set=>name=value; }
        public string Accountype { get=>accountType; set=>accountType=value; }
        public int Pin { get=>pin; set=>pin=value; }
        public double Amount { get=>amount; set=>amount=value; }

    }

}
