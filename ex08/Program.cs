using System;

// Enum for student grades
public enum Grade
{
    A,
    B,
    C,
    D,
    F
}

// Custom exception class for invalid grades
public class InvalidGradeException : Exception
{
    public InvalidGradeException(string message) : base(message)
    {
    }
}

// Student structure with attributes
public struct Student
{
    // Properties with attributes
    [StudentInfo("Adı")]
    public string Name { get; set; }

    [StudentInfo("Soyadı")]
    public string Surname { get; set; }

    [StudentInfo("Doğum Yılı")]
    public int BirthYear { get; set; }

    [StudentInfo("Not")]
    public Grade Grade { get; set; }

    // Method to print student information
    public void PrintStudentInfo()
    {
        Console.WriteLine($"Adı: {Name}");
        Console.WriteLine($"Soyadı: {Surname}");
        Console.WriteLine($"Doğum Yılı: {BirthYear}");
        Console.WriteLine($"Not: {Grade}");
    }
}

// Attribute class for student information
[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
sealed class StudentInfoAttribute : Attribute
{
    public string InfoName { get; }

    public StudentInfoAttribute(string infoName)
    {
        InfoName = infoName;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Create a student
            Student student = new Student
            {
                Name = "John",
                Surname = "Doe",
                BirthYear = 2000,
                Grade = Grade.A
            };

            // Print student information
            Console.WriteLine("Öğrenci Bilgileri:");
            student.PrintStudentInfo();

            // Demonstrate exception handling
            try
            {
                // Attempt to set an invalid grade
                student.Grade = (Grade)6;
            }
            catch (InvalidGradeException ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }

            // Demonstrate reflection
            Console.WriteLine("\nSınıfın Özellikleri ve Attribute'ları:");
            ReflectStudentClassProperties(student);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ana Hata: {ex.Message}");
        }
    }

    // Method to reflect on class properties and attributes
    static void ReflectStudentClassProperties(Student student)
    {
        Type type = student.GetType();

        foreach (var property in type.GetProperties())
        {
            Console.WriteLine($"Özellik Adı: {property.Name}");

            // Get custom attributes
            var attributes = property.GetCustomAttributes(typeof(StudentInfoAttribute), false);
            foreach (StudentInfoAttribute attribute in attributes)
            {
                Console.WriteLine($"  Attribute: {attribute.InfoName}");
            }
        }
    }
}
