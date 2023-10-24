namespace _11006_Number_Processor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputnumber = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int result = 0;

            while (command != "End")
            {
                if (command == "Inc")
                {
                    inputnumber += 1;
                }
                else if (command == "Dec")
                {
                    inputnumber -= 1;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(inputnumber);
        }
    }
}

//Write a program to process a sequence of commands:
//•	Read an initial number from the input
//•	Read an execute a sequence of the following commands:

// -  "Inc" – add 1 to the number (increment)
// -  "Dec" – subtract 1 from the number (decrement)
// -  "End" – print the number and stop the program
