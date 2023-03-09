namespace Simple_Inhiritance_Example
{
    public class School
    {
        private int id;
        private string name;
        private string city;
        private string country;
        public School(int id, string name, string city, string country)
        {
            this.id = id;
            this.name = name;
            this.city = city;
            this.country = country;
        }

        public string Location()
        {
            return $"The School is located in {city}, {country}";
        }
        public string Name()
        {
            return $"It's {name}!";
        }
        public string CommercialRegistration()
        {
            return $"It's {id}";
        }
        public override string ToString()
        {
            return $"School Name: {Name()}\n" +
                   $"School Location: {Location()}\n" +
                   $"School Commercial Registration: {CommercialRegistration()} \n" +
                   $"School Employees: {Employee.count} employees \n"+
                   "----------------------------------------\n";
        }
    }
}
