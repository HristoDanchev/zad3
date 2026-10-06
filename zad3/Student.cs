using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    internal class Student
    {

        private string fullName;
        private int facultyNumber;
        private string specialty;
        private string course;


        public string FullName
        {
            get => fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 3)
                {
                    throw new ArgumentException("Името не може да бъде празно или по-кратко от 3 символа.");
                }
                fullName = value.Trim();
            }
        }

        public int FacultyNumber
        {
            get => facultyNumber;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Факултетният номер трябва да бъде положително число (по-голямо от 0).");
                }
                facultyNumber = value;
            }
        }

        public string Specialty
        {
            get => specialty;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 3)
                {
                    throw new ArgumentException("Специалността трябва да съдържа поне 3 символа.");
                }
                specialty = value.Trim();
            }
        }

        public string Course
        {
            get => course;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 3)
                {
                    throw new ArgumentException("Курсът трябва да съдържа поне 3 символа.");
                }
                course = value.Trim();
            }
        }

       
        public Student()
        {
            FullName = "Неизвестен Студент";
            FacultyNumber = 100000;
            Specialty = "Неопределена";
            Course = "1-ви курс";
        }

        public Student(string fullName, int facultyNumber)
            : this() 
        {
            FullName = fullName;
            FacultyNumber = facultyNumber;
        }

        public Student(string fullName, int facultyNumber, string specialty, string course)
        {
            FullName = fullName;
            FacultyNumber = facultyNumber;
            Specialty = specialty;
            Course = course;
        }


        public void PrintStudentInfo()
        {
            Console.WriteLine("========================================");
            Console.WriteLine($" Трите имена:     {FullName}");
            Console.WriteLine($" Фак. номер:      {FacultyNumber}");
            Console.WriteLine($" Специалност:    {Specialty}");
            Console.WriteLine($" Курс:           {Course}");
            Console.WriteLine("========================================");
        }

        public override string ToString()
        {
            return $"Студент: {FullName} (ФАК.№: {FacultyNumber}), Специалност: {Specialty}, Курс: {Course}";
        }
    }
}
