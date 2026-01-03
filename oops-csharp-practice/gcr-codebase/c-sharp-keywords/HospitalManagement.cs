using System;

class HospitalManagement
{
    public static string HospitalName = "City Hospital";
    private static int totalPatients = 0;

    // readonly variable
    public readonly int PatientID;

    public string Name;
    public int Age;
    public string Ailment;

    // Constructor
    public HospitalManagement(string Name, int Age, string Ailment, int PatientID)
    {
        // using 'this' 
        this.Name = Name;
        this.Age = Age;
        this.Ailment = Ailment;
        this.PatientID = PatientID;

        totalPatients++;
    }

    // method to get total patients
    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
    }

    // method to display patient details
    public void DisplayDetails(object obj)
    {
        if (obj is HospitalManagement)
        {
            Console.WriteLine("Hospital Name: " + HospitalName);
            Console.WriteLine("Patient: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Ailment: " + Ailment);
            Console.WriteLine("Patient ID: " + PatientID);
        }
        else
        {
            Console.WriteLine("Object is not a Patient");
        }
    }

    // Main method
    static void Main()
    {
        HospitalManagement p1 = new HospitalManagement("Rahul", 30, "Fever", 101);
        HospitalManagement p2 = new HospitalManagement("Anita", 25, "Migraine", 102);

        p1.DisplayDetails(p1);
        Console.WriteLine();

        p2.DisplayDetails(p2);
        Console.WriteLine();

        HospitalManagement.GetTotalPatients();

        Console.ReadLine();
    }
}
