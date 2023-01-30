using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

class ReadPatientRecords
{
    static void Main(string[] args)
    {
        const char DELIM = ',';
        const string FILENAME = "Patients.txt";
        FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);
        string recordIn;
        string[] fields;
        WriteLine("{0, -20}{1, -20}{2, -20}", "ID Number", "Name", "Balance Due");
        recordIn = reader.ReadLine();
        while (recordIn != null)
        {
            fields = recordIn.Split(DELIM);
            double currency = Convert.ToDouble(fields[2]);
            WriteLine("{0, -20}{1, -20}{2, -20}", fields[0], fields[1], currency.ToString("C"));
            recordIn = reader.ReadLine();
        }
        reader.Close();
        inFile.Close();
    }
}

