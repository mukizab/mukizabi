namespace ConsoleApp2
{
    public class Salaries
    {
        public int empl_id;
        public string empl_name;
        public string empl_position;
        public string empl_gender;

        public double calculateSalaries(double grossSalaries)
        {
            double Salaries;
            Salaries = grossSalaries - ((grossSalaries * 0.3) + (grossSalaries * 0.05) + (grossSalaries * 0.03));
            return Salaries;
            

        }

        public double calculateSalaries(double rate, double hour)
        {
            double Salaries;
            Salaries = ((rate * hour) - (((rate * hour) * 0.05) + (rate * hour) * 0.03));
            return Salaries;
            
        }

        public double calculateSalaries(int grossSalaries)
        { 
             double salaries;
            salaries = grossSalaries - (grossSalaries * 0.3);
            return salaries;
        }
            
            
    }
}