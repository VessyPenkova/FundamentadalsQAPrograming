namespace _17004_List_Manipulation_Basics__Lab_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                List<string> commandsParts = command.Split(" ").ToList();
                string firstPartOfTheCommand = commandsParts[0];
                //string secondPartOfTheCommand = command.Substring(1);
                if (firstPartOfTheCommand == "Add")
                {
                    int numberToAdd = int.Parse(commandsParts[1]);
                    numbersInput.Add(numberToAdd);
                }
                else if (firstPartOfTheCommand == "Remove")
                {
                    int numberToRemove = int.Parse(commandsParts[1]);
                    numbersInput.Remove(numberToRemove);
                }
                else if (firstPartOfTheCommand == "RemoveAt")
                {
                    int numberToRemoveAtIndex = int.Parse(commandsParts[1]);
                    numbersInput.RemoveAt(numberToRemoveAtIndex);
                }
                else if (firstPartOfTheCommand == "Insert")
                {
                    int numberToInsert = int.Parse(commandsParts[1]);
                    int numberToInserAtIndex = int.Parse(commandsParts[2]);
                    numbersInput.Insert(numberToInserAtIndex, numberToInsert);
                }
                command = Console.ReadLine();
            }
            Console.Write(String.Join(" ", numbersInput));
           //Console.WriteLine(string.Join(" ", nums));
        }
    }
}

//Write a program that: 
//•	Reads a list of integers
//•	Then until you receive "end", you will receive different commands:
//      V       "Add {number}": add a number to the end of the list
//      V       "Remove {number}": remove a number from the list
//      V       "RemoveAt {index}": remove a number at a given index
//      'V      "Insert {number} {index}": insert a number at a given index
//•	When you receive the "end" command, print the final state of the list (separated by spaces)
//Note: All the indices will be valid!
