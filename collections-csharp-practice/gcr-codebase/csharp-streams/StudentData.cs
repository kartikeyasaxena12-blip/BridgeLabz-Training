using System;
using System.IO;

class StudentBinaryData
{
    static void Main()
    {
        string filePath = "student.dat";

        //Writing data to binary file
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(101);          // Roll Number
            writer.Write("Kartikeya");  // Name
            writer.Write(8.7);          // GPA
        }

        Console.WriteLine("Student data saved successfully.\n");

        //Reading data from binary file
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            int rollNo = reader.ReadInt32();
            string name = reader.ReadString();
            double gpa = reader.ReadDouble();

            Console.WriteLine("Retrieved Student Data:");
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("GPA: " + gpa);
        }
    }
}
