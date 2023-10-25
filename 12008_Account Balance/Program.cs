namespace _12008_Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double balance = 0;
            while (true)
            {
                if (command == "End")
                {
                    Console.WriteLine($"Balance: {balance:f2}");
                    break;
                }
                double amount = double.Parse(command);

                if (amount < 0)
                {
                    balance += amount;
                    double mathabs = Math.Abs(amount);
                    Console.WriteLine($"Decrease: {mathabs:F2}");
                   
                }
                if (amount>0)
                {
                    balance += amount;
                    Console.WriteLine($"Increase: {amount:f2}");
                    
                }              
                command = Console.ReadLine();
            }
        }
    }
}

//Write a program to calculate an account balance:
//•	Read a sequence of incomes / expenses, until "End" is read
//•	Add the money to the balance (starting form 0)
//•	Print "Increase: {money}" or "Decrease: {money}", where value is formatted to the second decimal digit
//•	Finally, print the account balance, formatted to the second decimal digit in the following format: "Balance: {account balance}"
