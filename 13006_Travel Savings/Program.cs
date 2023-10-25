namespace _13006_Travel_Savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    return;
                }
                double budget = double.Parse(Console.ReadLine());
                double sum = 0.0;
                while (sum < budget)
                {
                    double money = double.Parse(Console.ReadLine());
                    sum += money;
                    Console.WriteLine($"Collected: {sum:F2}");
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}

//Write a program that calculate the money collection for multiple travel destinations:
// V    •	Read a destination (string)
// V    •   Needed budget (floating-point number) for the destination
// V    •	Read many times amounts of collected money, until (Budgwt >= saved Money) they are enough for the destination (starting from 0)

//o   Print: 
//"Collected: {sum:F2}" where sum is formatted to 2nd digit
//    or
// "Going to {destination}"
//•	Read another destination and budget and collect money again
//•	A destination "End" ends the program
