namespace _17004A_List_Manipulation_Basics__Lab_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string command = Console.ReadLine(); //входни данни: валидна команда или "end"

            while (command != "end")
            {
                if (command.StartsWith("Contains"))
                {
                    //1. command = "Contains 6".Split(" ") -> ["Contains", "6"]
                    int numberContained = int.Parse(command.Split(" ")[1]); //число, което ще проверявам дали го има в списъка
                    if (numbers.Contains(numberContained))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    //2. command = "PrintEven"
                    foreach (int number in numbers)
                    {
                        if (number % 2 == 0)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine(); //нов ред след списъка с четни числа
                }
                else if (command == "PrintOdd")
                {
                    //3. command = "PrintOdd"
                    foreach (int number in numbers)
                    {
                        if (number % 2 != 0)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine(); //нов ред след списъка с нечетнни числа
                }
                else if (command == "GetSum")
                {
                    //4. command = "GetSum"
                    Console.WriteLine(numbers.Sum());
                }
                else if (command.StartsWith("Filter"))
                {
                    //5. command = "Filter >= 3".Split(" ") -> ["Filter", "<", "3"]
                    string condition = command.Split(" ")[1]; //условие: '<', '>', ">=", "<="
                    int number = int.Parse(command.Split(" ")[2]); //число, за което ще изпълняваме условието
                    switch (condition)
                    {
                        case "<":
                            numbers.RemoveAll(numberInList => numberInList >= number);
                            break;
                        case ">":
                            numbers.RemoveAll(numberInList => numberInList <= number);
                            break;
                        case "<=":
                            numbers.RemoveAll(numberInList => numberInList > number);
                            break;
                        case ">=":
                            numbers.RemoveAll(numberInList => numberInList < number);
                            break;
                    }
                }

                command = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

//Write a program that: 
//•	Reads a list of integers
//•	Then until you receive "end", you will receive different commands:
//o "Add {number}": add a number to the end of the list
//o	"Remove {number}": remove a number from the list
//o	"RemoveAt {index}": remove a number at a given index
//o	"Insert {number} {index}": insert a number at a given index
//•	When you receive the "end" command, print the final state of the list (separated by spaces)
//Note: All the indices will be valid!
