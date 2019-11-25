using System;
using ConsoleApp1;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        
            Customer bien=new Customer();
            string f_name;
            string l_name;
            string gender;
            f_name = Console.ReadLine();
            bien.setfirstname(f_name);
            l_name = Console.ReadLine();
            bien.setlastname(l_name);
            gender= Console.ReadLine();
            bien.setgender(gender);
            int acc_nber;
            string acc_type;
            string currency;

            acc_nber = Convert.ToInt32(Console.ReadLine());
            acc_type = Console.ReadLine();
            currency = Console.ReadLine();

            Account me =new Account(acc_nber, acc_type, currency); 
            
            Console.WriteLine("Deposited amount");
            double savedAmount;
            Convert.ToDouble(Console.ReadLine());
           
            
            Console.WriteLine("withdrawed amount ");
            double withdrawAmount;
            Convert.ToDouble(Console.ReadLine());
           
            



        }
    }
}