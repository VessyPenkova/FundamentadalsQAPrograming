namespace _14006._Methods_Lab_Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNumbre = int.Parse(Console.ReadLine());
            int onPower = int.Parse(Console.ReadLine());

            int result = RiseNumberOnPower(baseNumbre, onPower);
            Console.WriteLine(result);

            static int RiseNumberOnPower(int n, int p)
            {
                int result = n;
                for (int i = 0; i < p-1; i++)
                {
                   result *=  n ;
                }
                return result ;
            }
        }
    }
}


//namespace _14006._Methods_Lab_Math_Power second solution
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int baseNumbre = int.Parse(Console.ReadLine());
//            int onPower = int.Parse(Console.ReadLine());

//            Console.WriteLine(RiseNumberOnPower(baseNumbre, onPower));

//            static int RiseNumberOnPower(int n, int p)
//            {
//                int result = n;
//                for (int i = 0; i < p - 1; i++)
//                {
//                    result *= n;
//                }
//                return result;
//            }
//        }
//    }
//}


//Write a program that:
//•	Reads two integer numbers from the console: base number and power
//•	Create a method, which receives two numbers as parameters:
//o The first number – the base
//o	The second number – the power
//•	The method should return the base raised to the given power
