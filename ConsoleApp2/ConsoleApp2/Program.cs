using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Salaries sal=new Salaries();
            sal.empl_id = Convert.ToInt32(Console.ReadLine());
            sal.empl_name = Console.ReadLine();
            sal.empl_position = Console.ReadLine();
            sal.empl_gender = Console.ReadLine();

            double grossSalaries;
            grossSalaries = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine($"{sal.empl_name} MonthlySalary for {sal.empl_position} is {sal.calculateSalaries(grossSalaries)}");
             Console.WriteLine($"{sal.empl_name} OneTimeSalary for {sal.empl_position} is {sal.calculateSalaries(grossSalaries)}");
              Console.WriteLine("your rate");
              double rate;
              rate = Convert.ToDouble(Console.ReadLine());
              double hour;
              hour = Convert.ToDouble(Console.ReadLine());
              if (rate != 0 && hour != 0)
              {
                  Console.WriteLine($"{sal.empl_name} Hourly salary is {sal.calculateSalaries(rate,hour)}");
              }
              else
              {
                  Console.WriteLine("Hourly salary is 0");
              }
        }
    }
}