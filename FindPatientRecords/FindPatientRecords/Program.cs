using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

class FindPatientRecords
{
    static void Main(string[] args)
    {
        const char DELIM = ',';
        const string FILENAME = "Patients.txt";
        FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);
        string recordIn;
        string[] fields;
        int idFind;
        Write("Enter the ID number information you would like to find: ");
        idFind = Convert.ToInt32(ReadLine());
        recordIn = reader.ReadLine();
        bool foundRecord = false;
        while (recordIn != null)
        {
            fields = recordIn.Split(DELIM);
            double currency = Convert.ToDouble(fields[2]);
            int idNumber = Convert.ToInt32(fields[0]);
            if (idNumber == idFind)
            {
                WriteLine("{0, -20}{1, -20}{2, -20}", "ID Number", "Name", "Balance Due");
                WriteLine("{0, -20}{1, -20}{2, -20}", fields[0], fields[1], currency.ToString("C"));
                foundRecord = true;
            }
            recordIn = reader.ReadLine();

        }
        if (!foundRecord)
        {
            WriteLine("Sorry, no records found.");
        }
        reader.Close();
        inFile.Close();
    }
}
