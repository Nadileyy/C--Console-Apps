using System;

namespace Simple_Inhiritance_Example
{
    class IT : Employee
    {
        private const decimal HARDSHIP = 150m;
        private string position;
        private string gender;
        public IT(int id, string name, int age, string phoneNumber, string city, string country, string email, decimal wage, decimal loggedTimeHours,string gender,string position) :
            base(id, name, age, phoneNumber, city, country, email, wage, loggedTimeHours)
        {
            this.gender = gender;
            this.position = position;
        }

        protected override decimal CalculateAll()
        {
            return base.CalculateAll() + HARDSHIP;
        }

        private string GetPosition()
        {
            if (gender.ToLower() == "male")
            {
                return $"His position is {position}";
            }
            else
            {
                return $"Her position is {position}";
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"Total Salary: {Math.Round(this.CalculateBasicSalary(), 2):N0}\n" +
                $"Hard ship: {HARDSHIP}\n" +
                $"Position: {GetPosition()}\n"+
                "----------------------------------------\n";
        }
    }
}
