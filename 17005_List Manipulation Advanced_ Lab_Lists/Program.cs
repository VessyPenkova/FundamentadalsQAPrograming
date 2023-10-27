using System.Diagnostics;
using System.Runtime.Serialization;

namespace _17005_List_Manipulation_Advanced__Lab_Lists
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
            List<int> filteresList = new List<int>();
            bool isItOriginalLisaAmmende = false;
            while (command != "end")
            {
                List<string> commandsParts = command.Split(" ").ToList();
                string firstPartOfTheCommand = commandsParts[0];
                //string secondPartOfTheCommand = command.Substring(1);
                if (firstPartOfTheCommand == "Contains")
                {
                    int numberToCheckIfAvailable = int.Parse(commandsParts[1]);
                    if (numbersInput.Contains(numberToCheckIfAvailable) == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else if (numbersInput.Contains(numberToCheckIfAvailable) == false)
                    {
                        Console.WriteLine("No such number");
                    }
                    isItOriginalLisaAmmende = false;
                }
                else if (firstPartOfTheCommand == "PrintEven")
                {
                    List<int> evenNumber = new List<int>();
                    for (int i = 0; i < numbersInput.Count; i++)
                    {
                        int currentNumberToCheckISItEven = numbersInput[i];
                        if (currentNumberToCheckISItEven % 2 == 0)
                        {
                            evenNumber.Add(currentNumberToCheckISItEven);
                        }
                    }
                    Console.WriteLine(string.Join(" ", evenNumber));
                    isItOriginalLisaAmmende = false;
                }
                else if (firstPartOfTheCommand == "PrintOdd")
                {
                    List<int> oddNumber = new List<int>();
                    for (int i = 0; i < numbersInput.Count; i++)
                    {
                        int currentNumberToCheckISItEven = numbersInput[i];
                        if (currentNumberToCheckISItEven % 2 != 0)
                        {
                            oddNumber.Add(currentNumberToCheckISItEven);
                        }
                    }
                    Console.WriteLine(string.Join(" ", oddNumber));
                    isItOriginalLisaAmmende = false;
                }
                else if (firstPartOfTheCommand == "GetSum")
                {
                    int sum = numbersInput.Sum();
                    Console.WriteLine(sum);
                    isItOriginalLisaAmmende = false;
                }
         
                else if (firstPartOfTheCommand == "Filter")
                {
                    string contition = commandsParts[1];
                    int number = int.Parse(commandsParts[2]);
                    if (contition == "<")
                    {
                        for (int i = 0; i < numbersInput.Count; i++)
                        {
                            int currentNumberToCheckISItEven = numbersInput[i];
                            if (currentNumberToCheckISItEven < number)
                            {
                                filteresList.Add(currentNumberToCheckISItEven);
                            }
                        }
                        isItOriginalLisaAmmende = true;
                    }
                    else if (contition == ">")
                    {
                        for (int i = 0; i < numbersInput.Count; i++)
                        {
                            int currentNumberToCheckISItEven = numbersInput[i];
                            if (currentNumberToCheckISItEven > number)
                            {
                                filteresList.Add(currentNumberToCheckISItEven);
                            }
                        }

                        isItOriginalLisaAmmende = true;
                    }
                    else if (contition == ">=")
                    {
                        for (int i = 0; i < numbersInput.Count; i++)
                        {
                            int currentNumberToCheckISItEven = numbersInput[i];
                            if (currentNumberToCheckISItEven >= number)
                            {
                                filteresList.Add(currentNumberToCheckISItEven);
                            }
                        }
                        isItOriginalLisaAmmende = true;

                    }
                    else if (contition == "<=")
                    {
                        for (int i = 0; i < numbersInput.Count; i++)
                        {
                            int currentNumberToCheckISItEven = numbersInput[i];
                            if (currentNumberToCheckISItEven <= number)
                            {
                                filteresList.Add(currentNumberToCheckISItEven);
                            }
                        }
                        isItOriginalLisaAmmende = true;
                    }
                }

                command = Console.ReadLine();
            }
            if (command == "end")
            {
                if (isItOriginalLisaAmmende == true)
                {
                    Console.Write(String.Join(" ", filteresList));
                }
                else if (isItOriginalLisaAmmende != true)
                {
                    Console.Write(String.Join(" ", numbersInput));
                }
            }
        }
    }
}

//•	Reads a list of integers
//•	Then until you receive "end", you will receive different commands:
//      V       "Contains {number}" – check if the list contains the number and if so - print "", otherwise print "No such number"
//      V       "PrintEven" – print all the even numbers, separated by a space
//      V       "PrintOdd" – print all the odd numbers, separated by a space
//      V       "GetSum" – print the sum of all the numbers
//      V       Filter {condition} {number}" – left in the list all the numbers that
//      V       fulfill the given condition.
//              1 2 3 4 < 5 6 7 8 
//      V       The condition will be either '<', '>', ">=", "<="
//•	When you receive the "end" command, print the final state of the list (separated by spaces)
