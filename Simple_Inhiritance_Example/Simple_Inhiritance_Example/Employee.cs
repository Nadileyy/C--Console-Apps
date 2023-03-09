using System;

namespace Simple_Inhiritance_Example
{
    class Employee
    {
        private const int MINIMUM_LOGGED_HOURS = 176;
        private const decimal OVER_TIME_RATE = 1.25m;

        protected int id;
        protected string name;
        protected int age;
        protected string phoneNumber;
        protected string city;
        protected string country;
        protected string email;
        protected decimal wage;
        protected decimal loggedTimeHours;

        public static int count =0;

        public Employee(int id, string name, int age, string phoneNumber, string city, string country, string email, decimal wage, decimal loggedTimeHours)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.phoneNumber = phoneNumber;
            this.city = city;
            this.country = country;
            this.email = email;
            this.wage = wage;
            this.loggedTimeHours = loggedTimeHours;
            count++;
        }

        public static int GetEmployees()
        {
            return count;
        }

        protected virtual decimal CalculateAll()
        {
            return CalculateBasicSalary() + CalculateOverTime();
        }
        protected decimal CalculateBasicSalary()
        {
            return wage * loggedTimeHours;
        }
        protected decimal CalculateOverTime()
        {
            var additionalHours = ((loggedTimeHours - MINIMUM_LOGGED_HOURS) > 0 ? (loggedTimeHours - MINIMUM_LOGGED_HOURS) : 0);
            return additionalHours * wage * OVER_TIME_RATE;
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("Simple_Inhiritance_Example.", "");
            return $"Employee Type: {type}\n" +
                   $"ID: {id}\n" +
                   $"Name: {name}\n" +
                   $"Logged Hours: {loggedTimeHours}\n" +
                   $"Wage: {wage} $/hr\n" +
                   $"Basic Salary: ${Math.Round(this.CalculateBasicSalary(), 2):N0}\n" +
                   $"Over Time Salary: ${Math.Round(this.CalculateOverTime(), 2):N0}\n";
        }
    }
}
