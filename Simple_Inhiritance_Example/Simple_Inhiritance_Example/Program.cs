using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;

namespace Simple_Inhiritance_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***************** Teacher 1 *****************/

            List<string> nadilCourses = new List<string>();
            nadilCourses.Add("C#");
            nadilCourses.Add("Lab2");

            List<string> nadilLevels = new List<string>();
            nadilLevels.Add("Level 1");
            nadilLevels.Add("Level 2");

            Employee nadil = new Teacher(1,"Nadil Iyad", 23,"0780767266",
                "Irbid", "Jordan", "nadil@gmail.com", 2.25m, 250m,nadilCourses,nadilLevels);
            Console.WriteLine(nadil);

            /***************** Teacher 2 *****************/

            List<string> basmaCourses = new List<string>();
            basmaCourses.Add("Java");
            basmaCourses.Add("Requirement");

            List<string> basmaLevels = new List<string>();
            basmaLevels.Add("Level 5");
            basmaLevels.Add("Level 6");
            Employee basma = new Teacher(1, "Basma Khaled", 33, "0780765841",
                "Amman", "Jordan", "basma12@gmail.com", 2.3m, 185m, basmaCourses, basmaLevels);
            Console.WriteLine(basma);

            /***************** IT *****************/

            Employee it = new IT(1, "Mohammad Salem", 45, "0780767266",
                "Irbid", "Jordan", "nadil@gmail.com", 3m, 190m, "Male", "Software Engineer");
            Console.WriteLine(it);

            School school = new School(15248,"Monterial School","Amman","Jordan");
            Console.WriteLine(school);
        }
    }
}
