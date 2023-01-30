using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


class Auction
{
    static void Main(string[] args)
    {
        const int MINBID = 10;
        int intBid;
        double doubBid;
        string input;
        Write("Enter your bid for the auction: ");
        input = ReadLine();
        WriteLine();
        if (int.TryParse(input, out intBid))
        {
            placeBid(intBid, MINBID);
        } 
        else if (double.TryParse(input, out doubBid))
        {
            placeBid(doubBid, MINBID);
        } 
        else
        {
            placeBid(input, MINBID);
        }
    }

    static void placeBid (int bid, int min)
    {
        if(bid >= min)
        {
            WriteLine("Your bid of {0} is acceptable. Bid has been placed.", bid.ToString("C"));
        }
        else
        {
            WriteLine("Sorry, your bid of {0} less than {1}, the minimum acceptable bid.", bid.ToString("C"), min.ToString("C"));
        }
    }

    static void placeBid(double bid, int min)
    {
        if (bid >= min)
        {
            WriteLine("Your bid of {0} is acceptable. Bid has been placed.", bid.ToString("C"));
        }
        else
        {
            WriteLine("Sorry, your bid of {0} less than {1}, the minimum acceptable bid.", bid.ToString("C"), min.ToString("C"));
        }
    }

    static void placeBid(string bid, int min)
    {
        double doubBid;
        if (bid.StartsWith("$") || bid.EndsWith("dollars"))
        {
            bid = bid.Trim(' ', '$', 'd', 'o', 'l', 'a', 'r', 's', 'D', 'O', 'L', 'A', 'R', 'S');
            if(double.TryParse(bid, out doubBid))
            {
                if (doubBid >= min)
                {
                    WriteLine("Your bid of {0} is acceptable. Bid has been placed.", doubBid.ToString("C"));
                }
                else
                {
                    WriteLine("Sorry, your bid of {0} less than {1}, the minimum acceptable bid.", doubBid.ToString("C"), min.ToString("C"));
                }
            }
            else
            {
                WriteLine("Error, invalid bid entered.");
            }
        }
        else
        {
            WriteLine("Error, invalid bid entered.");
        }
    }
}

