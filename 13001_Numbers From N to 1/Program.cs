namespace _13001_Numbers_From_N_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

//Write a program that:
//Reads an integer number N from the console
//Prints the numbers from N to 1, each on separate line
