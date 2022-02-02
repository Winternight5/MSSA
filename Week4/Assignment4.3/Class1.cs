using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._3
{
    enum Grades
    {
        A, B, C, D, E, F
    }
    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    struct Student
    {
        public int Sid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Grades Grade { get; set; }
        public Months MonthOfAdmission { get; set; }
    }
}
