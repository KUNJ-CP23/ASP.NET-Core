using System;

namespace Lab2.Classes
{
    class Student
    {
        string Enrollment_No;
        string Student_Name;
        int Semester;
        double CPI;
        double SPI;

        public Student(string enrollmentNo, string name, int semester, double cpi, double spi)
        {
            Enrollment_No = enrollmentNo;
            Student_Name = name;
            Semester = semester;
            CPI = cpi;
            SPI = spi;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("---- Student Details ----");
            Console.WriteLine("Enrollment Number: " + Enrollment_No);
            Console.WriteLine("Student Name: " + Student_Name);
            Console.WriteLine("Semester: " + Semester);
            Console.WriteLine("CPI: " + CPI);
            Console.WriteLine("SPI: " + SPI);
        }
    }
}
