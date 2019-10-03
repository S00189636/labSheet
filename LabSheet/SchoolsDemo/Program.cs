using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsDemo
{
    class Program
    {
        static List<School> schools = new List<School>();
        static void Main(string[] args)
        {
            int schoolsCount = 1;
            schoolsCount = int.Parse(GetInput("how many schools - (min 1 , max 99+) ?"));
            for (int i = 0; i < schoolsCount; i++)
            {
                string input = null;
                School school = new School();
                input = GetInput("school name: ");
                school.SetName(input);
                input = GetInput("Enrolled students number in "+ school.GetName()+":");
                school.SetNumber(int.Parse(input));
                schools.Add(school);
            }
            Console.WriteLine("You have added {0} schools", schools.Count);
            schools.Sort((s1, s2) => s1.GetName().CompareTo(s2.GetName()));
            Console.WriteLine("Schools sorted");
            Console.WriteLine();
            PrintSchools();
            Console.ReadLine();
        }

        private static string GetInput(string message)
        {
            Console.Write("Please enter {0} ", message);
            return Console.ReadLine();
        }

        static public void PrintSchools()
        {
            foreach (School item in schools)
            {
                Console.WriteLine("{0} has {1} students", item.GetName(), item.GetEnrolledStudents());
            }
        }
    }
}
