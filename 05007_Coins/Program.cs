namespace _05007_Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int countCounter = 0;
            while (change > 0)
            {
                if (change >= 2)
                {
                    change -= 2;
                    countCounter++;
                }
                else if (change >= 1)
                {
                    change -= 1;
                    countCounter++;
                }
                else if (change >= 0.5m)
                {
                    change -= 0.5m;
                    countCounter++;
                }
                else if (change >= 0.2m)
                {
                    change -= 0.2m;
                    countCounter++;
                }
                else if (change >= 0.1m)
                {
                    change -= 0.1m;
                    countCounter++;
                }
                else if (change >= 0.05m)
                {
                    change -= 0.05m;
                    countCounter++;
                }
                else if (change >= 0.02m)
                {
                    change -= 0.02m;
                    countCounter++;
                }
                else if (change >= 0.01m)
                {
                    change -= 0.01m;
                    countCounter++;
                }

            }
            Console.WriteLine(countCounter);
        }
    }
}

//Vending machine manufacturers aim to make their machines return the least amount of coin change possible.
//Write a program that takes an amount - the change that needs to be returned, and calculates how it can be done
//with the minimum possible number of coins.
//Hint: Coins accepted by the vending machine: 2 leva, 1 lev, 50 stotinki, 20 stotinki, 10 stotinki, 5 stotinki, 2 stotinki, 1 stotinka
