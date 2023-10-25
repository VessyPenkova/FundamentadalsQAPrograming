namespace _13004_Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stores = int.Parse(Console.ReadLine());
            int things = int.Parse(Console.ReadLine());
            char type = 'L';
            for (int i = stores; i > 0; i--)
            {
                for (int j = 0; j < things; j++)
                {
                    Console.Write($"{type}{i}{j} ");
                }
                if (i % 2 == 0)
                {
                    type = 'A';
                }
                else
                {
                    type = 'O';
                }
                Console.WriteLine();
            }
        }
    }
}

//Write a program to print a table, representing a building:
//•	Reads two integer numbers from the console: floors count and estates count per floor
//•	Identifiers consist of: { type}
//{ floor}
//{ number}, e.g.L65, A12, O24
//•	Odd floors hold apartments (type A), e.g.A10, A11, A12, …
//•	Even floors hold offices (type O), e.g.O20, O21, O22, …
//•	The last floor holds large apartments (type L), e.g.L60, L61, L62
