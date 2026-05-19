using System;
using System.Runtime.CompilerServices;

namespace ProfessorClasses
{
    public class Professor
    {
        private string firstName;
        private string lastName;
        private int lnumber;
        private string department;

        public Professor(string firstName, string lastName, int lnumber, string department)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.lnumber = lnumber;
            this.department = department;
        }

        public string FirstName
        {
            get { return firstName; }
            set {firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set {lastName = value; }
        }

        public string Department
        {
            get { return department; }
            set {department = value; }
        }

        public int Lnumber
        {
            get { return lnumber; }
            set { 
                if(value > 99999999 || value < 10000000) 
                    throw new ArgumentOutOfRangeException(nameof(value));
                lnumber = value;
            }
        }
    }
}
