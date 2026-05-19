using System;

using ProfessorClasses;

namespace ProfessorTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor("John", "Pork", 12345678, "CIT");

            Console.WriteLine(professor.FirstName);
            Console.WriteLine(professor.LastName);
            Console.WriteLine(professor.Lnumber);
            Console.WriteLine(professor.Department);

            professor.Lnumber = 1234567;

        }
    }
}
