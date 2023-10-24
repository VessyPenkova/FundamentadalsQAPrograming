namespace _08009_Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfTheTicket = Console.ReadLine();
            int seatsrowsInTheHall = int.Parse(Console.ReadLine());
            int seatscolsInTheHall = int.Parse(Console.ReadLine());

            int amountOfTheSeatsTotal = seatsrowsInTheHall * seatscolsInTheHall;
            double totalAmountFromTheTickets = 0;

            if (typeOfTheTicket == "Premiere")
            {
                totalAmountFromTheTickets = 12 * amountOfTheSeatsTotal;
            }
            if (typeOfTheTicket == "Normal")
            {
                totalAmountFromTheTickets = 7.50 * amountOfTheSeatsTotal;
            }
            if (typeOfTheTicket == "Discount")
            {
                totalAmountFromTheTickets = 5.00 * amountOfTheSeatsTotal;
            }
            Console.WriteLine($"{totalAmountFromTheTickets:f2}");
        }
    }
}

//Write a program, that calculates the price for all the tickets for a cinema movie:
// - 	Reads the type of the movie (string), the count of the rows (an integer number)
//and count of the seats per row (an integer number) in the cinema 
// - 	Type of the movie will be one of the following: "Premiere", "Normal" and "Discount"
// - 	Prints the total price for all seats formatted to the 2nd digit after the decimal point,
// based on the table below:
//=========================
//||  Type    ||  Price  ||
//=========================
//|| Premiere || 12.00   ||
//-------------------------
//|| Normal   ||  7.50   ||
//-------------------------
//|| Discount ||  5.00   ||
//-------------------------

 
