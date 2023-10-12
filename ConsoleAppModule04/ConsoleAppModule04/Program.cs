using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule04
{
    internal class Practice
    {
        static void Main()
        {
            Student[] students = new Student[10]
            {
                new Student("Arystanbek","M","B", 2,new int[] {5,5,5,5,5}),
                new Student("Zhumygaliev","E","K", 3,new int[] {5,4,5,4,5}),
                new Student("Tolegenov","I","A", 1,new int[] {5,5,4,5,5}),
                new Student("Onlan","D","A", 1,new int[] {4,5,3,2,2}),
                new Student("Amirsheev","N","S", 3,new int[] {3,4,3,5,2}),
                new Student("Tokpan","O","B", 2,new int[] {4,4,3,2,2}),
                new Student("Zhasan","A","K", 1,new int[] {5,4,4,5,5}),
                new Student("Nurtas","K","N", 3,new int[] {4,4,5,2,3}),
                new Student("Abil","B","B", 2,new int[] {3,4,3,3,4}),
                new Student("Kyrdebai","N","D", 1,new int[] {3,3,5,2,4}),
            };
            var sort = students.OrderBy(student => student.AverageGrade()).ToArray();

            Console.WriteLine("Students with grades 4 or 5: ");
            foreach (var student in sort)
            {
                if (student.Grades.All(grade => grade >= 4))
                {
                    Console.WriteLine($"FIO: {student.LastName}.{student.FirstName}.{student.MiddleName}, Group: {student.GroupNumber}");
                }
            }
            Console.ReadKey();
        }
    }
    struct Student
    {
        public string LastName, FirstName, MiddleName;
        public int GroupNumber;
        public int[] Grades;

        public Student(string lastName, string firstName, string middleName, int groupNumber, int[] grades)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            GroupNumber = groupNumber;
            Grades = grades;
        }

        public double AverageGrade()
        {
            return Grades.Average();
        }
    }
}