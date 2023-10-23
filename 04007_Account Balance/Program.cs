namespace _04007_Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0.0;
            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);
                if (amount < 0)
                { //TODO: Print output and exit the loop }
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else if (amount >= 0)
                {
                    balance += amount;
                    Console.WriteLine($"Increase: {amount:F2}");
                    input = Console.ReadLine();

                }
            }
            Console.WriteLine($"Total: {balance:F2}");
        }
    }
}
//Write a program that calculates the total amount of money in an account after making a certain number of
//deposits.
//On each line, you will receive the amount that you need to deposit into the account, until youreceive the
//command "NoMoreMoney".
//For each received amount, you should output "Increase: " + the amount
//and add it to the account balance.
//If you receive a number less than 0, you should output "Invalid operation!" and the program should terminate.
//When the program finishes, it should print "Total: " + the total amount in the account formatted to two decimal
//places after the decimal point.
