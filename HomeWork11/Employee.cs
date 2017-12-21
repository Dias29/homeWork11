using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Employee
    {
        private string FName { get; set; }
        private string LName { get; set; }
        private int Salary { get; set; }
        private DateTime Recruit { get; set; }
        PostEnum _post;

        private int Day { get; set; }
        private int Month { get; set; }
        private int Year { get; set; }

        public Employee(string fname, string lname, PostEnum post, int salary , int year, int month, int day)
        {
            FName = fname;
            LName = lname;
            _post = post;
            Salary = salary;
            Recruit = new DateTime(year, month, day);
        }

        
    }
}
