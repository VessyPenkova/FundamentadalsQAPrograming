namespace _14005_Methods_Lab_Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToBeReaited = Console.ReadLine();
            int timeToRepeat = int.Parse(Console.ReadLine());

            Console.WriteLine(StringRepeater(stringToBeReaited, timeToRepeat));

           
            static string StringRepeater(string str, int n)
            {              
                string stringOutPut = "";
                for (int i = 0; i < n; i++)
                {
                    stringOutPut += str;
                }
                return stringOutPut;                
            }
        }
    }
}

//Write a program that:
//•	Reads a text (string) and repeat count (integer number) from the console
//•	Write a method that receives a string and a repeat count 
//•	The method should return a new string, containing the initial one, repeated count times without space
