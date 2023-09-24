namespace _05_TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packagesOfPens = int.Parse(Console.ReadLine());
            int packageOfMarkers = int.Parse(Console.ReadLine());
            int boardCleanerLiters = int.Parse(Console.ReadLine());
            int pecentageDiscount = int.Parse(Console.ReadLine());

            double pricePerPensPackage = 5.80;
            double pricePerMarkersPackage = 7.20;
            double pricePerLiterLiquid = 1.20;

            double priceBeforeDiscount =
                (packagesOfPens * pricePerPensPackage) +
                (packageOfMarkers * pricePerMarkersPackage) +
                (boardCleanerLiters * pricePerLiterLiquid);

            // Console.WriteLine(priceBeforeDiscount);

            double discountAmount = priceBeforeDiscount / 100 * pecentageDiscount;

            // Console.WriteLine(discountAmount);

            Double finalPrice = priceBeforeDiscount - discountAmount;

            Console.WriteLine(finalPrice);

        }
    }
}
//5.Teaching materials
//The school year has already started.
//The 10B grade manager - Annie has to buy a certain number of packets of pens, packets with markers,
//as well as board cleaner.
//She is a regular client of a bookstore, so there is a discount for her,
//which represents some discount percentage of the total amount.
//Write a program that calculates how much money Annie will need to collect to pay the bill,
//keeping in mind the following price list: 
//  V   •	Package of pens - 5.80 lv. V
//  V   •	Package of markers - 7.20 lv. 
//  V   •	Board cleaner - 1.20 BGN (per liter)

//Input
//From the console read 4 numbers:
//•	Number of packages of pens - integer in the range [0...100]
//•	Number of packets of markers - integer in the range [0...100]
//•	Liters of board cleaner - an integer in the range [0... 50]
//•	Discount percentage - integer in the range [0...100]
//Output
//Print on the console how much money will Annie need to pay the bill.


