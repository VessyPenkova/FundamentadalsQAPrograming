namespace _13007_Sum_of_Digits_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (true)
            {
                
                int sum = 0;
                if (command == "End")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                int digit = int.Parse(command);
                for (int i = 0; i < command.Length; i++)
                {
                    int RealNumber = Convert.ToInt32(command[i]) - '0';
                    // Convert the char on position[i]from the sequence as number from Ascii table
                    sum+= RealNumber;
                }
                Console.WriteLine($"Sum of digits = {sum}");
                command = Console.ReadLine();
            }
        }
    }
}

//Write a program that:
//•	Continuously read integers until "End" is entered from the console
//o	Print the sum of digits for each integer, use the following format: 
//"Sum of digits = {sum}"
//•	Finally, print "Goodbye"
