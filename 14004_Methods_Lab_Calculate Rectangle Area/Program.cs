namespace _14004_Methods_Lab_Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());


            int area = AreaOfRectangle(sideA, sideB);

            Console.WriteLine(area);



            static int AreaOfRectangle (int a, int b)
            {
                return  a * b;
            }   
        }
    }
}