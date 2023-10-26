namespace _17001_Change_List__Lab_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine() 
                    .Split(" ")        
                    .Select(int.Parse) 
                    .ToList();         


            string command = Console.ReadLine();
            while (command != "end")
            {
                
                string[] commandParts = command.Split(" ");
                string commandName = commandParts[0]; 
                int element = int.Parse(commandParts[1]);

                if (commandName == "Delete")
                {
                   
                    numbers.RemoveAll(number => number == element);
                }
                else if (commandName == "Insert")
                {
                    int position = int.Parse(commandParts[2]);
                    numbers.Insert(position, element);

                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

//Write a program that:
//•	Reads a list of integers from the console and receives commands to manipulate the list
//•	Then until you receive "end", you will receive different commands:
//o "Delete {element}" – delete all elements in the array, which are equal to the given element
//o	"Insert {element} {position}" – insert the element at the given position
//•	When you receive the "end" command, print the final state of the list (separated by spaces)
