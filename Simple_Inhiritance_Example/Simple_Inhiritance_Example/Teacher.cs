using System;
using System.Collections;
using System.Collections.Generic;

namespace Simple_Inhiritance_Example
{
    class Teacher : Employee
    {
        private const decimal HARDSHIP = 100m;

        private List<string> courses;
        private List<string> levels;
        public Teacher(int id, string name, int age, string phoneNumber, string city, string country, string email, decimal wage, decimal loggedTimeHours, List<string> courses, List<string> levels):
            base (id, name, age, phoneNumber, city, country, email, wage, loggedTimeHours)
        {
            this .courses = courses;
            this .levels = levels;
        }

        protected override decimal CalculateAll()
        {
           return base.CalculateAll()+HARDSHIP;
        }
        private string Courses()
        {
            return string.Join(", ", courses);
        }
        private string Levels()
        {
            return string.Join(", ", levels);
        }

        public override string ToString()
        {
            return base.ToString() +  
                $"Hard ship: ${HARDSHIP}\n"+
                $"Total Salary: ${Math.Round(this.CalculateAll(), 2):N0}\n" +
                $"Courses: {Courses()}\n" +
                $"Levels: {Levels()}\n" +
                "----------------------------------------\n";
        }
    }
}
