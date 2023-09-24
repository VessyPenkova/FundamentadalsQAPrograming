namespace _08_Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anualBasketballFee = int.Parse(Console.ReadLine());

            double sneakersPrice = anualBasketballFee*0.6;
            double teampPrice = sneakersPrice * 0.8;
            double basketballPrice = teampPrice / 4;
            double accessoriesPrice = basketballPrice / 5;

            double jessieSpends = sneakersPrice + teampPrice + basketballPrice +
                                  accessoriesPrice + anualBasketballFee;

            Console.WriteLine(jessieSpends);
        }
    }
}
//8.Basketball equipment
//Jesse decides he wants to play basketball,
//but he needs equipment to train. Write a program that calculates the expenses of Jesse
//if he starts training, knowing how much is the fee for basketball training for a period of 1 year. 

//  V •	Basketball sneakers – their price is 40% less than the fee for one year
//  V •	Basketball team – its price is 20% cheaper than that of sneakers
//  V •	Basketball – its price is 1 / 4 of the price of the basketball team
//  V •	Basketball accessories – their price is 1 / 5 of the price of the basketball

//Input
//From the console read 1 row:

//  V   •	The annual basketball training fee – an integer in the range [0... 9999]

//Output

//Print on the console how much Jesse will spend if he starts playing basketball.
