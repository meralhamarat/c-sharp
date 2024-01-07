using System;

public enum Grade
{
    A,
    B,
    C,
    D,
    F
}

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
sealed class StudentInfoAttribute : Attribute
{
    public string InfoName { get; }

    public StudentInfoAttribute(string infoName)
    {
        InfoName = infoName;
    }
}

public struct Student
{
    [StudentInfo("Adı")]
    public string Name { get; set; }

    [StudentInfo("Soyadı")]
    public string Surname { get; set; }

    [StudentInfo("Doğum Yılı")]
    public int BirthYear { get; set; }

    [StudentInfo("Not")]
    public Grade Grade { get; set; }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Adı: {Name}");
        Console.WriteLine($"Soyadı: {Surname}");
        Console.WriteLine($"Doğum Yılı: {BirthYear}");
        Console.WriteLine($"Not: {Grade}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        Console.Write("Adınız: ");
        student.Name = Console.ReadLine();

        Console.Write("Soyadınız: ");
        student.Surname = Console.ReadLine();

        Console.Write("Doğum Yılınız: ");
        if (int.TryParse(Console.ReadLine(), out int birthYear))
        {
            student.BirthYear = birthYear;
        }
        else
        {
            Console.WriteLine("Geçersiz bir doğum yılı girdiniz.");
            return;
        }

        // Rastgele bir not atama
        var random = new Random();
        student.Grade = (Grade)random.Next(0, Enum.GetValues(typeof(Grade)).Length);

        Console.WriteLine("\nÖğrenci Bilgileri:");
        student.PrintStudentInfo();

        Console.WriteLine("\nSınıfın Özellikleri ve Attribute'ları:");
        ReflectStudentClassProperties(student);
    }

    static void ReflectStudentClassProperties(Student student)
    {
        Type type = student.GetType();

        foreach (var property in type.GetProperties())
        {
            Console.WriteLine($"Özellik Adı: {property.Name}");

            var attributes = property.GetCustomAttributes(typeof(StudentInfoAttribute), false);
            foreach (StudentInfoAttribute attribute in attributes)
            {
                Console.WriteLine($"  Attribute: {attribute.InfoName}");
            }
        }
    }
}
