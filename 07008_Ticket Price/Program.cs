using System.ComponentModel;

namespace _07008_Ticket_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();

            if (ticketType == "student")
            {
               Console.WriteLine("$1.00");
            }
            else if (ticketType == "regular")
            {
               Console.WriteLine("$1.60");
            }
            else
            {
               Console.WriteLine("Invalid ticket type!");
            }
        }
    }
}

//Write a program to calculate ticket price, which:
//Reads a ticket type: either "student" or "regular"
//Prints the price in the following format "${price}":
//Student ticket price: 1.00
//Regular ticket price: 1.60
//For invalid type "Invalid ticket type!"
