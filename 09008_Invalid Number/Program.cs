namespace _09008_Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool isValid = true;
         
            if (input < 100 || input > 200)
            {
               isValid= false;
            }

            if (input == 0)
            {
                isValid = true;
            }

            if (isValid == false)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}

//A given number is valid if it is in the range [100...200] or it is equals to 0. 
//Write a program that:
//•	Reads an integer from the console
//•	 Prints "invalid" if the entered number is NOT valid
