using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public class Account
    {
        private int acc_nber;
        private string acc_type;
        private static string currency;
        private double initialBalance;

        public Account(int acc_nber, string acc_type, string currency)
        {
            throw new NotImplementedException();
        }

        {
        


        this.acc_nber = this.acc_nber;
        this.acc_type = this.acc_type;
        


    if (currency.ToLower().Equals("frw")) ;
        {
                this.initialBalance=50000;
            }
            if (currency.ToLower().Equals("usd"));
            {
                this.initialBalance = 50;
            }
            if (currency.ToLower().Equals("euro")) ;
            {
                this.initialBalance = 50;
            }
        }

        public void save(double amount)
        {
            if (amount != 0)
            {
                initialBalance = initialBalance + amount;
                Console.WriteLine($"balance now is {initialBalance}");
                
            }
            else
            {
                Console.WriteLine("you can not deposit");
            }
        }

        public void withdraw(double amount)
        {
            if (amount != 0)
            {
                initialBalance = initialBalance - amount;
                Console.WriteLine($"balance now is{initialBalance}");
                
            }
            else
            {
               Console.WriteLine("insufficient balance ");
               
              
            }
        }

        }
}