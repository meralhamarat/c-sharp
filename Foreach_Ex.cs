/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Foreach_Ex.cs                                                            */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Öğrenci sınıfını kullanarak bir öğrenci koleksiyonu oluşturalım
        List<Student> students = new List<Student>
        {
            new Student("Ali", "Matematik", 90),
            new Student("Ayşe", "Fizik", 85),
            new Student("Mehmet", "Kimya", 78),
            new Student("Zeynep", "Biyoloji", 95),
            new Student("Can", "Matematik", 88)
        };

        // Tüm öğrencileri ekrana yazdıralım
        Console.WriteLine("Tüm Öğrenciler:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        // Matematik dersinden geçen öğrencileri seçelim
        var passingMathStudents = students.Where(s => s.Subject == "Matematik" && s.Grade >= 70);

        Console.WriteLine("\nMatematik Dersinden Geçen Öğrenciler:");
        foreach (var student in passingMathStudents)
        {
            Console.WriteLine(student);
        }

        // Not ortalamasını hesaplayalım
        double averageGrade = students.Average(s => s.Grade);

        Console.WriteLine($"\nNot Ortalaması: {averageGrade:F2}");

        // Öğrencileri notlarına göre sıralayalım
        var sortedStudents = students.OrderByDescending(s => s.Grade);

        Console.WriteLine("\nNotlarına Göre Sıralanmış Öğrenciler:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }

        Console.ReadLine(); // Konsol penceresini açık tut
    }

    // Öğrenci sınıfını tanımlayalım
    class Student
    {
        public string Name { get; }
        public string Subject { get; }
        public int Grade { get; }

        public Student(string name, string subject, int grade)
        {
            Name = name;
            Subject = subject;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{Name}, {Subject} - Not: {Grade}";
        }
    }
}
