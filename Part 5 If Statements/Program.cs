using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose a program from the following:");
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
            int balance = generator.Next(100, 150);
            Console.WriteLine($"Welcome {name}! Your current balance is {balance}$ Blorbian Dollars");
            Console.WriteLine("You will be charged a fee of 0.75$ for this banking session");
            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("\nChoose and action from the following: Deposit, Withdrawal, Payment, Balance");
                string response = Console.ReadLine().ToUpper();

                switch (response)
                {
                    case "DEPOSIT":
                        deposit();
                        exit = true;
                        break;
                    case "WITHDRAWAL":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Not a valid Input!");
                        break;
                }

            }

            void deposit()
            {
                Console.WriteLine("Depositing");
            }
        }
    }
}
