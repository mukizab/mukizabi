namespace ConsoleApp3
{
    public class Customer
    {
        private string f_name;
        private string l_name;
        private string gender;

        public void setfirstname(string f_name)
        {
            this.f_name = this.f_name;
        }

        public void setlastname(string l_name)
        {
            this.l_name = this.l_name;
            
        }
        public void setgender(string gender)
        {
            this.gender = this.gender;

        }

        public string getfirstname()
        {
            return f_name;
        }

        public string getlasttname()
        {
            return l_name;
        }

        public string getgender()
        {
            return gender;
            
        }
    }
}