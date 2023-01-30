using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LetterDemo
{
    class LetterDemo
    {
        static void Main(string[] args)
        {
            Letter letter = new Letter();
            letter.Name = "Mr. Anderson";
            letter.Date = "11/6/20";
            WriteLine(letter.ToString());
            WriteLine();
            CertifiedLetter certifiedLetter = new CertifiedLetter();
            certifiedLetter.Name = "Sully James Sullivan";
            certifiedLetter.Date = "11/4/20";
            certifiedLetter.TrackingNumber = "T2087WZ09783";
            WriteLine(certifiedLetter.ToString() + ", Tracking Number: " + certifiedLetter.TrackingNumber);
        }
    }
    class Letter
    {
        public string Name { get; set; }
        public string Date { get; set; }
        new public string ToString()
        {
            return ("Type: " + GetType() + ", Name of recipient: " + Name + ", Date mailed: " + Date);
        }
    }
    class CertifiedLetter : Letter
    {
        public string TrackingNumber { get; set; }
    }
}
