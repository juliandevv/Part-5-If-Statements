using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Part_5_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nChoose a program from the following:");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Bank of Blorb[1]  ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Parking Cost Calculator[2] ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Hurricane Severity[3]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                string response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        bankBlorb();
                        break;

                    case "2":
                        parkingCost();
                        break;

                    case "3":
                        hurricaneSeverity();
                        break;

                    default:
                        Console.WriteLine("Not a valid Input!");
                        break;
                }
            }
        }

        static void bankBlorb()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random generator = new Random();
            Console.WriteLine("Welcome to the bank of Blorb!\nPlease enter your name");
            string name = Console.ReadLine();
            double balance = Convert.ToDouble(generator.Next(100, 150));
            Console.WriteLine($"Welcome {name}!");
            Console.WriteLine("You will be charged a fee of 0.75$ for this banking session");
            bool exit = false;


            while (exit == false)
            {
                Console.WriteLine("\nChoose and action from the following: Deposit, Withdrawal, Payment, Balance, Exit");
                string response = Console.ReadLine().ToUpper();

                switch (response)
                {
                    case "DEPOSIT":
                        deposit();
                        break;

                    case "WITHDRAWAL":
                        withdrawal();
                        break;

                    case "PAYMENT":
                        payment();
                        break;

                    case "BALANCE":
                        balanceCheck();
                        break;

                    case "EXIT":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Not a valid Input!");
                        break;
                }

            }

            void deposit()
            {
                Console.WriteLine("Please enter the amount you would like to deposit:");
                int amount;
                while (true)
                {
                    string response = Console.ReadLine();

                    if (int.TryParse(response, out amount))
                    {
                        Console.WriteLine($"You are depositing {amount}$...");
                        
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input!");
                    }
                }

                Thread.Sleep(1000);
                Console.WriteLine("\nBoB Receipt");
                string bar = new string('=', 22);
                Console.WriteLine(bar);
                Console.WriteLine($"Original balance: {balance}$");
                Console.WriteLine($"Deposit amount: {amount}$");
                Console.WriteLine($"Service Charge: {0.75}$");
                balance = (balance - 0.75) + amount;
                Console.WriteLine($"Final balance: {balance}$");
                Console.WriteLine();
                Console.WriteLine("Press ENTER to return home");
                Console.ReadLine();
            }
            void withdrawal()
            {
                Console.WriteLine($"Your current balance is {balance}$ Blorbian Dollars");
                Console.WriteLine("Please enter the amount you would like to withdraw:");
                int amount;
                while (true)
                {
                    string response = Console.ReadLine();

                    if (int.TryParse(response, out amount) && amount < balance)
                    {
                        Console.WriteLine($"You are withdrawing {amount}$...");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input!");
                    }
                }

                Thread.Sleep(1000);
                Console.WriteLine("\nBoB Receipt");
                string bar = new string('=', 22);
                Console.WriteLine(bar);
                Console.WriteLine($"Original balance: {balance}$");
                Console.WriteLine($"Deposit amount: {amount}$");
                Console.WriteLine($"Service Charge: {0.75}$");
                balance = (balance - 0.75) - amount;
                Console.WriteLine($"Final balance: {balance}$");
                Console.WriteLine();
                Console.WriteLine("Press ENTER to return home");
                Console.ReadLine();
            }

            void payment()
            {
                Console.WriteLine($"Your current balance is {balance}$ Blorbian Dollars");
                int amountDue = generator.Next(0, Convert.ToInt32(balance));
                Console.WriteLine($"You owe: {amountDue}$");
                Console.WriteLine("Would you like to pay this now?");
                Thread.Sleep(3000);
                Console.WriteLine("Just kidding! You don't have a choice.");

                Thread.Sleep(1000);
                Console.WriteLine("\nBoB Receipt");
                string bar = new string('=', 22);
                Console.WriteLine(bar);
                Console.WriteLine($"Original balance: {balance}$");
                Console.WriteLine($"Payment amount: {amountDue}$");
                Console.WriteLine($"Service Charge: {0.75}$");
                balance = (balance - 0.75) - amountDue;
                Console.WriteLine($"Final balance: {balance}$");
                Console.WriteLine();
                Console.WriteLine("Press ENTER to return home");
                Console.ReadLine();
            }

            void balanceCheck()
            {
                Console.WriteLine($"Your current balance is {balance}$ Blorbian Dollars");
                Thread.Sleep(1000);
                Console.WriteLine("\nBoB Receipt");
                string bar = new string('=', 22);
                Console.WriteLine(bar);
                Console.WriteLine($"Original balance: {balance}$");
                Console.WriteLine($"Service Charge: {0.75}$");
                balance = balance - 0.75;
                Console.WriteLine($"Final balance: {balance}$");
                Console.WriteLine();
                Console.WriteLine("Press ENTER to return home");
                Console.ReadLine();
            }
        }

        static void parkingCost()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nWelcome to Sam's parking garage!");
            Console.WriteLine("How many minutes have you been encroaching on Sam's property?");
            double parkingTime;
            double hours;
            double amountDue;

            while (true)
            {
                string response = Console.ReadLine();

                if (double.TryParse(response, out parkingTime))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid input!");
                }
            }

            hours = Math.Ceiling(Convert.ToDouble(parkingTime/60));
            Console.WriteLine($"For convenience's sake I'll round that up to {hours} hours");
            double days = Math.Floor(hours / 24);
            hours = hours - (days * 24) -1;
            if (hours < 0) { hours = 0; }
            amountDue = 4;
            amountDue += days * 20;
            amountDue += (hours) * 2;
            
            Console.WriteLine($"That means you owe me {amountDue.ToString("C")}");
            Console.WriteLine("Thanks for using Sam's garage! Come again soon!");
            Thread.Sleep(2500);
        }

        static void hurricaneSeverity()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEnter the category of a hurricane to find out it's wind speed!");

            string response = Console.ReadLine();

            switch (response.ToUpper())
            {
                case "1": case"CATEGORY 1": case "CATEGORY1":
                    Console.WriteLine("\nCategory 1 hurricane windspeeds:\n74-95mph\n64-82kt\n119-153km/h");
                    break;

                case "2": case"CATEGORY 2": case "CATEGORY2":
                    Console.WriteLine("\nCategory 2 hurricane windspeeds:\n96-110mph\n83-95kt\n154-177km/h");
                    break;

                case "3": case"CATEGORY 3": case "CATEGORY3":
                    Console.WriteLine("\nCategory 3 hurricane windspeeds:\n111-130mph\n96-113kt\n178-209km/h");
                    break;

                case "4": case"CATEGORY 4": case "CATEGORY4":
                    Console.WriteLine("\nCategory 4 hurricane windspeeds:\n131-155mph\n114-135kt\n210-249km/h");
                    break;

                case "5": case"CATEGORY 5": case "CATEGORY5":
                    Console.WriteLine("\nCategory 5 hurricane windspeeds:\n>155mph\n>135kt\n>249km/h");
                    break;

                default:
                    Console.WriteLine("That's not a hurricane category!");
                    break;
            }
        }
    }
}
