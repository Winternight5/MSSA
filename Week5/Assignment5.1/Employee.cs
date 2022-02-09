using System;

namespace Assignment5._1
{
    enum Department
    {
        Administration,
        Finance,
        IT,
        Marketing,
        Sales
    }

    internal class Employee
    {
        public int Eid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public DateTime Dob { get; set; }

        private string _ssn;

        public string SSN
        {
            get {
                return string.Format("*****{0}", _ssn.Substring(_ssn.Length - 4));
            }
            set { _ssn = value; }
        }
    }
}