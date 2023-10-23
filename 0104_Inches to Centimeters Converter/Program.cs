namespace _0104_Inches_to_Centimeters_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double inches= double.Parse(Console.ReadLine());
            double inchesToSanctimeters = inches * 2.54;
            Console.WriteLine(inchesToSanctimeters);
        }
    }
}