using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Node<T>
{
    public T Data { get; set; }
    public Node<T>? Previous { get; set; }
    public Node<T>? Next { get; set; }
}

public class LinkedList<T> : IEnumerable<T>
{
    private class Node<T>
    {
        public T Data { get; set; }
        public Node<T>? Next { get; set; }
        public override string ToString() => $"Data = [{Data}]";
    }

    private Node<T>? _head, _tail;

    public void Add(T element)
    {
        var newNode = new Node<T> { Data = element };
        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail!.Next = newNode;
            _tail = newNode;
        }
    }

    private struct LinkedListEnumerator : IEnumerator<T>
    {
        private Node<T>? _currentNode;
        private readonly Node<T>? _head;

        public LinkedListEnumerator(Node<T>? head)
        {
            _head = head;
            _currentNode = new Node<T> { Data = default! };
            _currentNode.Next = _head;
        }

        public T Current => _currentNode!.Data;

        object? IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            _currentNode = _currentNode?.Next;
            return _currentNode != null;
        }

        public void Reset()
        {
            _currentNode = new Node<T> { Data = default! };
            _currentNode.Next = _head;
        }
    }

    public IEnumerator<T> GetEnumerator() => new LinkedListEnumerator(_head);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class Patient
{
    public long ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString() => $"{ID}. {FirstName} {LastName}";
}

public class Medicine
{
    public long ID { get; set; }
    public string Name { get; set; }

    public override string ToString() => $"{ID}. {Name}";
}

public class Doctor
{
    public long ID { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }

    public override string ToString() => $"{ID}. {Name} ({Specialty})";
}

public class Disease
{
    public long ID { get; set; }
    public string Name { get; set; }

    public override string ToString() => $"{ID}. {Name}";
}

class Program
{
    static void Main(string[] args)
    {
        var patientList = new LinkedList<Patient>
        {
            new Patient { ID = 46573806740, FirstName = "Hiranur", LastName = "Sazak" },
            new Patient { ID = 23746982347, FirstName = "Nisa Nur", LastName = "Özdal" },
            new Patient { ID = 89374938243, FirstName = "Nisa Gül", LastName = "Ünal" },
            new Patient { ID = 98723424674, FirstName = "Berfin", LastName = "Geleş" }
        };

        var medicineList = new LinkedList<Medicine>
        {
                new Medicine { ID = 46573806740, Name = "Theraflu Forte" },
                new Medicine { ID = 46573806740, Name = "Ketober %1.6 Gargara" },
                new Medicine { ID = 46573806740, Name = "Theraflu Forte" },
                new Medicine { ID = 46573806740, Name = "Ketober %1.6 Gargara" },
                new Medicine { ID = 46573806740, Name = "Aferin Sinüs" },
                new Medicine { ID = 23746982347, Name = "Paraflex 20 Komprime" },
                new Medicine { ID = 23746982347, Name = "Sul jel %3 30 gr Jel" },
                new Medicine { ID = 23746982347, Name = "Edolar 500 mg 14 ftb" },
                new Medicine { ID = 89374938243, Name = "Laksafenol" },
                new Medicine { ID = 89374938243, Name = "Axeparin" },
                new Medicine { ID = 89374938243, Name = "Cynacal" },
                new Medicine { ID = 98723424674, Name = "BlefariTTO Göz Jeli 20 ml" },
                new Medicine { ID = 98723424674, Name = "LOTEBRA %0.5 + %0.3 göz damlası" },
                new Medicine { ID = 98723424674, Name = "TERRAMYCIN 5 mg/ 10.000 IU göz merhemi" }
            };

            var doctorList = new LinkedList<Doctor>
            {
                new Doctor { ID = 46573806740, Name = "Dr. Ömer Kaplan", Specialty = "Ear, Nose, Throat" },
                new Doctor { ID = 23746982347, Name = "Dr. Ali Nazmican Güröz", Specialty = "Orthopedics" },
                new Doctor { ID = 89374938243, Name = "Dr. Bekir Borazan", Specialty = "Internal Medicine" },
                new Doctor { ID = 98723424674, Name = "Dr. Pınar İnan", Specialty = "Ophthalmology" }
            };

            var diseaseList = new LinkedList<Disease>
            {
                new Disease { ID = 46573806740, Name = "Nezle" };
                new Disease { ID = 46573806740, Name = "Farenjit" };
                new Disease { ID = 46573806740, Name = "Sinüzit" };
                new Disease { ID = 23746982347, Name = "Menisküs Yırtığı" };
                new Disease { ID = 89374938243, Name = "Gastroenteroloji" };
                new Disease { ID = 89374938243, Name = "Hematoloji" };
                new Disease { ID = 89374938243, Name = "Nefroloji" };
                new Disease { ID = 98723424674, Name = "Göz Enfeksiyonu" };

            };

            Console.WriteLine("\n...ID Query...");

        Console.Write("Please enter the ID number: ");
        if (long.TryParse(Console.ReadLine(), out long ID))
        {
            Patient? queriedPatient = patientList.FirstOrDefault(patient => patient.ID == ID);
            Medicine? queriedMedicine = medicineList.FirstOrDefault(medicine => medicine.ID == ID);
            Doctor? queriedDoctor = doctorList.FirstOrDefault(doctor => doctor.ID == ID);
            Disease? queriedDisease = diseaseList.FirstOrDefault(disease => disease.ID == ID);

            if (queriedPatient != null)
            {
                Console.WriteLine($"Patient Found: ID: {queriedPatient.ID}, First Name: {queriedPatient.FirstName}, Last Name: {queriedPatient.LastName}");
            }
            else if (queriedMedicine != null)
            {
                Console.WriteLine($"Medicine Found: ID: {queriedMedicine.ID}, Name: {queriedMedicine.Name}");
            }
            else if (queriedDoctor != null)
            {
                Console.WriteLine($"Doctor Found: ID: {queriedDoctor.ID}, Name: {queriedDoctor.Name}, Specialty: {queriedDoctor.Specialty}");
            }
            else if (queriedDisease != null)
            {
                Console.WriteLine($"Disease Found: ID: {queriedDisease.ID}, Name: {queriedDisease.Name}");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID number entered.");
        }

        Console.ReadKey();
    }
}
