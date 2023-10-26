namespace _15001_Stupid_Passwords_Exercise_Nested_Loops_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputnumber = int.Parse(Console.ReadLine());
            GeneratePassword(inputnumber);
        }

        private static void GeneratePassword(int inputnumber)
        {
            for (int i = 2; i <=inputnumber; i += 2)
            {
                for (int j = 1; j <= inputnumber; j += 2)
                {
                    Console.Write($"{i}{j}{i * j} ");
                }
            }
        }
    }
}

//Write a program that:
//•	Reads an integer number N from the console
//•	Generates all possible passwords consisting of the following 3 parts:
//o The first part is an even number in the range [2…N]
//o The second digit is an odd number in the range [1…N]
//o The third is the product of the first two
//•	The output holds all possible passwords
