namespace _05005_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingsCounter = 0;

            while (ownedMoney < neededMoney && spendingsCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;
                if (command == "spend")
                {
                    ownedMoney -= money;
                    if (ownedMoney <= 0)
                    {
                        ownedMoney = 0;
                    }
                    spendingsCounter++;
                }
                else if (command == "save")
                {
                    ownedMoney += money;
                    spendingsCounter--;
                }
            }
            if (spendingsCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (ownedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");

            }
        }
    }
}

//5.Vacation Savings
//Jessie has decided to save money for a vacation and she wants your help to determine
//if she will manage to save the required amount. Every day she either saves or spends a portion of her money.
//If she wants to spend more than she currently has, she will spend all of her money and end up with 0 leva.
//Input
//Read from the console:
//•	The money needed for the vacation - a real number in the range [1.00...25000.00]
//•	Available money - a real number in the range [0.00...25000.00]
//•	Then repeatedly read two lines:
//o Action type - a text with options "spend" and "save"
//o	Amount to save / spend - a real number in the range [0.01… 25000.00]
//Output
//The program should end in the following cases:
//•	If for 5 consecutive days Jessie only spends money, the console output should be:
//o   "You can't save the money."
//o   "{Total number of days passed}"
//•	If Jessie saves enough money for the vacation, console outputs:
//o   "You saved the money for {total number of days passed} days."
//Example Input and Output