using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankConsoleApplication
{
    class Program
    {
        List<Account> accountlist = new List<Account>();
        Account ac = new Account();
        public void DisplayMenu()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("Banking Console Application");
            Console.WriteLine("*********************************");
            bool value = true;
            while (value == true)
            {
                var table = new ConsoleTable("Choice", "Functionality Type");
                table.AddRow("1", "Add Bank Account");
                table.AddRow("2", "Withdrwal Account");
                table.AddRow("3", "Get Account Details");
                table.AddRow("4", "Deposit Amount");
                table.AddRow("5", "Check Balance");
                table.AddRow("6", "Exit");

                Console.WriteLine(table.ToString());
                Console.WriteLine("Enter the Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddBankAccount();
                        break;
                    case 2:

                        Console.WriteLine("Enter Amount for withdrwal");
                        double amountforwithdrwal = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Account Number");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter Account PIN");
                        int pin = Convert.ToInt32(Console.ReadLine());

                        foreach (var i in accountlist)
                        {
                            if (i.Pin == pin)
                            {
                                if (WithdrwalAmount(amountforwithdrwal, id, pin))
                                {
                                    Console.WriteLine("*********************************");
                                    Console.WriteLine("Withdrwal Successfully!");
                                    Console.WriteLine("*********************************");

                                }
                                else
                                {
                                    Console.WriteLine("*********************************");
                                    Console.WriteLine("Withdrwal Failed!");
                                    Console.WriteLine("*********************************");


                                }
                            }
                            else
                            {
                                Console.WriteLine("*********************************");
                                Console.WriteLine("Please try again! Enter valid aacount number and pin");
                                Console.WriteLine("*********************************");

                            }
                        }
                        

                        break;

                    case 3:
                        GetAccountDetails();
                        break;
                    case 4:
                        Console.WriteLine("Enter Amount for deposit");
                        double amountfordeposit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Account Number");
                        string accid = Console.ReadLine();
                        foreach (var i in accountlist)
                        {
                            if (i.Id == accid)
                            {

                                var result = (DepositAmount(amountfordeposit, accid)) ? "Money Deposited Successfully!" : "Deposition Failed!";
                                Console.WriteLine("*********************************");
                                Console.WriteLine(result);
                                Console.WriteLine("*********************************");


                            }
                            else
                            {
                                Console.WriteLine("*********************************");
                                Console.WriteLine("Please try again! Enter valid account number");
                                Console.WriteLine("*********************************");


                            }
                        }

                        break;
                    case 5:
                        Console.WriteLine("Enter Account Number");
                        string accountid = Console.ReadLine();
                        foreach (var i in accountlist)
                        {
                            if (i.Id == accountid)
                            {
                                GetBalance(accountid);

                            }
                            else
                            {
                                Console.WriteLine("*********************************");
                                Console.WriteLine("Account Not Found!!");
                                Console.WriteLine("*********************************");

                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("*********************************");
                        Console.WriteLine("Thank You!");
                        Console.WriteLine("*********************************");
                        value = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }

            }
        }

        bool DepositAmount(double amountfordeposit, string accid)
        {

            var getbalance = (from bankacc in accountlist where bankacc.Id == accid select bankacc.Amount).FirstOrDefault();

            var newdepositedamount = getbalance + amountfordeposit;
            foreach (var updatebalance in accountlist)
            {
                updatebalance.Amount = newdepositedamount;
            }
            if (newdepositedamount > getbalance)
                return true;
            return false;
        }

        void GetBalance(string accountid)
        {
            var balance = (from bankacc in accountlist where bankacc.Id == accountid select bankacc.Amount).FirstOrDefault();
            Console.WriteLine("*********************************");
            Console.WriteLine("Account Number:{0} and Account Balance:Rs.{1}", accountid, balance);
            Console.WriteLine("*********************************");


        }

        bool WithdrwalAmount(double amountforwithdrwal, string id, int pin)
        {

            var getbalance = (from b in accountlist where (b.Id == id && b.Pin == pin) select b.Amount).FirstOrDefault();

            if (amountforwithdrwal < getbalance)
            {
                var newbalance = getbalance - amountforwithdrwal;
                foreach (var updatebalance in accountlist)
                {
                    updatebalance.Amount = newbalance;

                }
                return true;

            }
            return false;


        }

        void GetAccountDetails()
        {

            foreach (var accountdetails in accountlist)
            {
                Console.WriteLine("Account Details:\n");
                Console.WriteLine("*********************************");
                Console.WriteLine("Account Number: " + accountdetails.Id);
                Console.WriteLine("*********************************");
                Console.WriteLine("Name: "+accountdetails.Name);
                Console.WriteLine("*********************************");
                Console.WriteLine("Account Type: " + accountdetails.Accountype);
                Console.WriteLine("*********************************");
                Console.WriteLine("Balance: Rs. " + accountdetails.Amount);
                Console.WriteLine("*********************************");

            }
        }

        void AddBankAccount()
        {
            ac.TakeAccountDetailsFromUser();
            accountlist.Add(new Account()
            {
                Id = ac.Id,
                Name = ac.Name,
                Accountype = ac.Accountype,
                Pin=ac.Pin,
                Amount = ac.Amount
            });
        }

        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.DisplayMenu();

        }
    }
}
