using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
class WritePatientRecords
{
    static void Main(string[] args)
    {
        const int END = 999;
        const string DELIM = ",";
        FileStream file = new FileStream("Patients.txt", FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(file);
        Patient patient = new Patient();
        int num;
        Write("Enter an ID number: ");
        num = Convert.ToInt32(ReadLine());
        while (num != 999)
        {
            patient.IdNumber = num;
            Write("Enter the patient name: ");
            patient.Name = ReadLine();
            Write("Enter the patient's current balance: ");
            patient.CurrentBalance = Convert.ToDouble(ReadLine());
            writer.WriteLine(patient.IdNumber + DELIM + patient.Name + DELIM + patient.CurrentBalance);
            Write("Enter ID number or 999 to stop: ");
            num = Convert.ToInt32(ReadLine());
        }
        writer.Close();
        file.Close();
    }
}

class Patient
{
    private int idNumber;
    private string name;
    private double currentBalance;

    public int IdNumber { get; set; }
    public string Name { get; set; }
    public double CurrentBalance { get; set; }
}