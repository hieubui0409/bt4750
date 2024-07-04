using System;
using System.Collections.Generic;

class Student
{
    public string ID { get; set; }
    public double GPA { get; set; }

    public Student(string id, double gpa)
    {
        ID = id;
        GPA = gpa;
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, double> dict1 = new Dictionary<string, double>();

        while (true)
        {
            Console.Write("Nhập ID (hoặc '#' để dừng): ");
            string id = Console.ReadLine();

            if (id == "#")
            {
                break;
            }

            Console.Write("Nhập GPA: ");
            string gpaInput = Console.ReadLine();
            if (double.TryParse(gpaInput, out double gpa) && gpa >= 0 && gpa <= 4)
            {
                dict1[id] = gpa;
            }
            else
            {
                Console.WriteLine("GPA không hợp lệ, bỏ qua sinh viên này.");
            }
        }

        Console.Write("Nhập ID của sinh viên cần tìm GPA: ");
        string searchID = "123456";
        
        if (dict1.TryGetValue(searchID, out double studentGpa))
        {
            Console.WriteLine($"Điểm trung bình của sinh viên có ID '{searchID}' là {studentGpa}");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy sinh viên có ID '{searchID}'");
        }
    }
}

