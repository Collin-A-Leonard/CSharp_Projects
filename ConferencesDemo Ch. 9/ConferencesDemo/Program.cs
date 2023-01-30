using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
class ConferencesDemo
{

    static void Main(string[] args)
    {
        WriteLine("Welcome, enter information about the 5 conferences.");
        WriteLine();
        Conference[] conferences = new Conference[5];
        for(int i = 0; i < conferences.Length; ++i)
        {
            conferences[i] = new Conference();
            Write("Enter conference name: ");
            conferences[i].GroupName = ReadLine();
            Write("Enter conference start date: ");
            conferences[i].StartDate = ReadLine();
            Write("Enter number of attendees: ");
            conferences[i].NumAttend = Convert.ToInt32(ReadLine());
            WriteLine();
        }
        Array.Sort(conferences);
        WriteLine();
        WriteLine("Your list of sorted conferences: ");
        WriteLine();
        for (int i = 0; i < conferences.Length; ++i)
        {
            WriteLine("Group name: {0}, Number Attending: {1}, Start Date: {2}.",
                conferences[i].GroupName, conferences[i].NumAttend, conferences[i].StartDate);
        }
    }

}

class Conference : IComparable
{
    private string groupName;
    private string startDate;
    private int numAttend;
    public string GroupName { get; set; }
    public string StartDate { get; set; }
    public int NumAttend { get; set; }
    int IComparable.CompareTo(object obj)
    {
        Conference temp = (Conference)obj;
        if (this.NumAttend > temp.NumAttend)
            return 1;
        else
        {
            if (this.NumAttend < temp.NumAttend)
                return -1;
            else
                return 0;
        }
    }
}
