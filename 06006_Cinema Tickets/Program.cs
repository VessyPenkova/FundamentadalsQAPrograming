namespace _06006_Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCounter = 0;
            int standartCounter = 0;
            int kidCounter = 0;
            int totalTickets = 0;

            while (true)
            {
                string movieName = Console.ReadLine();
                if (movieName == "Finish")
                {
                    break;
                }
                int freePlace = int.Parse(Console.ReadLine());
                int currentTickets = 0;
                for (int i = 0; i < freePlace; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "student")
                    {
                        studentsCounter++;
                    }
                    else if (ticketType == "standard")
                    {
                        standartCounter++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidCounter++;
                    }
                    totalTickets++;
                    currentTickets++;
                }
                Console.WriteLine($"{movieName} - {(double)currentTickets / freePlace * 100:f2}% full.");
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)studentsCounter / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standartCounter / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidCounter / totalTickets * 100:f2}% kids tickets.");
        }
    }
}

//Your task is to write a program that calculates statistics about movies screened at a cinema.
//You need to find the percentage of tickets sold for different ticket types: "student", "standard", and "kid".
//You also need to calculate the percentage of seats occupied for each movie.
//Input
//The input includes a sequence of integers and text:
//•	On the first line - the name of the movie - string
//•	On the second line - the available seats in the cinema for the specific movie - an integer in the range [1 … 100]
//•	Next, types of tickets are read from the console on separate lines,
//until we have received all ticket types or the "End" command is received:
//o The type of ticket - text ("student", "standard", "kid")
//•	After the "End" command is received, it might be received information for another movie or "Finish" command,
//that will end the program and should return summary for the tickets sold.
//Output
//The following lines should be printed on the console:
//•	After each movie, print what percentage of the cinema is full:
//	"{movie name} - {percentage}% full."
