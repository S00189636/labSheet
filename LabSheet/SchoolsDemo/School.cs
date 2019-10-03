using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsDemo
{
    class School
    {
        private string Name;
        private int EnrolledStudents;

        public School() { }
        public School(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetEnrolledStudents()
        {
            return EnrolledStudents;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetNumber(int number)
        {
            EnrolledStudents = number;
        }
    }
}
