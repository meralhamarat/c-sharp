using System;
using System.Collections.Generic;

// Patient class
public class Patient
{
    public long? ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Patient? Previous { get; set; }
    public Patient? Next { get; set; }

    public override string ToString()
    {
        return $"{ID}. {FirstName} {LastName}";
    }
}

// Medicine class
public class Medicine
{
    public long? ID { get; set; }
    public string Name { get; set; }
    public Medicine? Previous { get; set; }
    public Medicine? Next { get; set; }

    public override string ToString()
    {
        return $"{ID}. {Name}";
    }
}

// Doctor class
public class Doctor
{
    public long ID { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public Doctor? Previous { get; set; }
    public Doctor? Next { get; set; }

    public override string ToString()
    {
        return $"{ID}. {Name} ({Specialty})";
    }
}

// Disease class
public class Disease
{
    public long ID { get; set; }
    public string Name { get; set; }
    public Disease? Previous { get; set; }
    public Disease? Next { get; set; }

    public override string ToString()
    {
        return $"{ID}. {Name}";
    }
}

// Doubly linked circular list class
public class Node<T>
{
    public T? ID { get; set; }
    public Node<T>? Previous { get; set; }
    public Node<T>? Next { get; set; }
}

public class DoublyLinkedCircularList<T>
{
    private Node<T>? Head;

    public void Add(T element)
    {
        Node<T> newNode = new Node<T> { ID = element };

        if (Head == null)
        {
            Head = newNode;
            Head.Previous = Head;
            Head.Next = Head;
        }
        else
        {
            newNode.Previous = Head.Previous;
            newNode.Next = Head;
            Head.Previous!.Next = newNode;
            Head.Previous = newNode;
        }
    }

    public T? QueryById(Func<T, bool> query)
    {
        if (Head == null)
            return default;

        Node<T> current = Head;
        do
        {
            if (query(current.ID!))
                return current.ID;

            current = current.Next!;
        } while (current != Head);

        return default;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Doubly linked circular lists
        DoublyLinkedCircularList<Patient> patientList = new DoublyLinkedCircularList<Patient>();
        DoublyLinkedCircularList<Medicine> medicineList = new DoublyLinkedCircularList<Medicine>();
        DoublyLinkedCircularList<Doctor> doctorList = new DoublyLinkedCircularList<Doctor>();
        DoublyLinkedCircularList<Disease> diseaseList = new DoublyLinkedCircularList<Disease>();

        // Add sample data
        patientList.Add(new Patient { ID = 46573806740, FirstName = "Hiranur", LastName = "Sazak" });
        patientList.Add(new Patient { ID = 23746982347, FirstName = "Nisa Nur", LastName = "Özdal" });
        patientList.Add(new Patient { ID = 89374938243, FirstName = "Nisa Gül", LastName = "Ünal" });
        patientList.Add(new Patient { ID = 98723424674, FirstName = "Berfin", LastName = "Geleş" });

        medicineList.Add(new Medicine { ID = 46573806740, Name = "Theraflu Forte" });
        medicineList.Add(new Medicine { ID = 46573806740, Name = "Ketober %1.6 Gargara" });
        // ... (add more medicines)

        doctorList.Add(new Doctor { ID = 46573806740, Name = "Dr. Ömer Kaplan", Specialty = "Ear, Nose, Throat" });
        doctorList.Add(new Doctor { ID = 23746982347, Name = "Dr. Ali Nazmican Güröz ", Specialty = "Orthopedics" });
        // ... (add more doctors)

        diseaseList.Add(new Disease { ID = 46573806740, Name = "Cold" });
        diseaseList.Add(new Disease { ID = 23746982347, Name = "Meniscus Tear" });
        // ... (add more diseases)

        Console.WriteLine("\n...ID Query...");

        Console.Write("Please enter the ID number: ");
        if (long.TryParse(Console.ReadLine(), out long ID))
        {
            Patient? queriedPatient = patientList.QueryById(patient => patient.ID == ID);

            if (queriedPatient != null)
            {
                Console.WriteLine($"ID: {queriedPatient.ID}, First Name: {queriedPatient.FirstName}, Last Name: {queriedPatient.LastName}");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID number entered.");
        }
        Console.ReadKey();
    }
}
