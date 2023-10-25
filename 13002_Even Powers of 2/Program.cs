namespace _13002_Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;
            }
        }
    }
}

//Write a program that:
//3
//1*2 = 1;
//2*2 = 4;
//2*2*2*2 = 16
//2*2*2*2*2 = 64
//•	Reads an integer number n from the console 
//•	Prints on the console the number two on even powers in the range [0; n]
//2 ≤ 2n: 20, 22, 24, 26, …, 2n.
