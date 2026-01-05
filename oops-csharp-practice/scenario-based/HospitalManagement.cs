using System;
class HospitalManagement
{
    static void Main(string[]args)
    {
        Doctor d = new Doctor("Dr. Sharma", "Cardiologist");
        d.Display();
        Console.WriteLine();

        Patient p1= new InPatient(101, "Ajay", 47, 5, 5000);
        p1.DisplayInfo();
        Console.WriteLine();

        Patient p2= new OutPatient(105, "Manu", 66, 1500);
        p2.DisplayInfo();
    }
}

class Doctor
{
    private string doctorName;
    private string spec;

    public Doctor(string name, string specs)
    {
        doctorName = name;
        spec = specs;
    }

    public void Display()
    {
        Console.WriteLine("Doctor Name = "+doctorName);
        Console.WriteLine("Specialization = " +spec);
    }
}

class Patient
{
    private int patientId;
    private string name;
    private int age;

    public Patient(int id, string n, int a)
    {
        patientId= id;
        name = n;
        age = a;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Patient Id = "+patientId);
        Console.WriteLine("Patient Name = "+name);
        Console.WriteLine("Patient Age = "+age);
    }

}

interface IPayable
{
    double CalculateBill();
}

class InPatient : Patient, IPayable
{
    private int daysAdmitted;
    private double dailyCharge;

    public InPatient(int id, string name, int age, int days, double charge) : base(id, name, age)
    {
        daysAdmitted = days;
        dailyCharge = charge;
    }

    public double CalculateBill()
    {
        return daysAdmitted * dailyCharge;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Patient Type: In-Patient");
        Console.WriteLine("Days Admitted: " + daysAdmitted);
        Console.WriteLine("Total Bill: Rs" + CalculateBill());
    }
}

class OutPatient : Patient, IPayable
{
    private double consultFee;
    public OutPatient(int id, string name, int age, double fee): base(id, name, age)
    {
        consultFee = fee;
    }

    public double CalculateBill()
    {
        return consultFee;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Patient Type: In-Patient");
        Console.WriteLine("Consultation Fee = "+consultFee);

    }
}