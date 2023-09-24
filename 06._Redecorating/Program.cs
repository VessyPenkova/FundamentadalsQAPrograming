namespace _06._Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int requiredAmountOfNylonInSM = int.Parse(Console.ReadLine());
            int insuranceQuantityNylonInSquareMaeters = 2;
            int finalNaylonAmountinSquareMeters = requiredAmountOfNylonInSM + insuranceQuantityNylonInSquareMaeters;

            int requireAmountOfPaintInLiters = int.Parse(Console.ReadLine());
            double finalPaintingsQuantity = requireAmountOfPaintInLiters* 1.1 ;

            int quantityOfThinnerInLiters = int.Parse(Console.ReadLine());
            int hoursForCraftsmenWork = int.Parse(Console.ReadLine());
            // * Prices
            double protectiveNylonPrice = 1.50;
            double PaintPrice = 14.50;      
            double paintThinnerPrice = 5.00;
            double bagsPrice = 0.40;
            int workPercentage = 30;

            double naylonBudget = finalNaylonAmountinSquareMeters * protectiveNylonPrice;
            // Console.WriteLine(naylonBudget);
            double paintsBudjets = finalPaintingsQuantity * PaintPrice;
            // Console.WriteLine(paintsBudjets);
            double thinnerBudget = quantityOfThinnerInLiters * paintThinnerPrice;
            // Console.WriteLine(thinnerBudget);

            double budget =
                (naylonBudget + paintsBudjets + thinnerBudget + bagsPrice);

            // Console.WriteLine(budget);

            double workPrice = (budget / 100 * workPercentage)* hoursForCraftsmenWork;

            // Console.WriteLine(workPrice);

            double finalBudget = budget + workPrice;

            Console.WriteLine(finalBudget);


        }
    }
}
//6.Redecorating

//Rumen wants to repaint the living room and has hired craftsmen for this purpose.
//Write a program that calculates the cost of the repair, taking the following prices for the calculation:

//  V •	Protective nylon - 1.50 BGN per square meter
//  V •	Paint - 14.50 BGN per liter
//  V •	Paint thinner - 5.00 BGN per liter
//  V • Just in case, to the necessary materials, Rumen wants to add another 10% of the amount of paint
//  V • and 2 square meters of nylon
//  V • also 0.40 leva for bags.
//The amount paid to the craftsmen for 1 hour of work is equal to 30% of the sum of all material costs. 


//Input

//The input is read from the console and contains exactly 4 lines:
//  V 1.Required amount of nylon (in sq.m.) -an integer number in the range [1... 100]
//  V 2.Required amount of paint (in liters) -an integer number in the range [1... 100]
//  V 3.Quantity of thinner(in liters) -integer number in the range[1... 30]
//  V 4.Hours needed for the craftsmen to do the work - an integer number in the range [1... 9]

//Output
//Print out only one line on the console:
//•	"{the sum of all costs}"
