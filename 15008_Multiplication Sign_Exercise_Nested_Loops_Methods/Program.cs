namespace _15008_Multiplication_Sign_Exercise_Nested_Loops_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            FindTheSignOftheMultiplyProduct(num1, num2, num3);
        }

        private static void FindTheSignOftheMultiplyProduct(int num1, int num2, int num3)
        {
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
            }

            else if (num1 != 0 && num2 != 0 && num3 != 0)
            {
                int signCounter = 0;
                if (num1 < 0 && num1 !=0)
                {
                    signCounter++;
                }
                if (num2 < 0 && num2 !=0)
                {
                    signCounter++;
                }
                if (num3 < 0 && num3 != 0)
                {
                    signCounter++;
                }
                if (signCounter % 2 != 0)
                {
                    Console.WriteLine("negative");
                }
                else if (signCounter % 2 == 0)
                {
                    Console.WriteLine("positive");
                }
            }
        }
    }
}

//Write a program that:
//•	Reads three integer numbers:
//  - int num1
//  - int num2
//  - int num3 from the console
//•	 Finds if num1 * num2 * num3(the product) is negative, positive or zero
//•	Print:
//o negative - if the product is smaller than 0 
//o	positive - if the product is bigger than 0
//o	zero - if the product is equals to 0
//Note: Try to do this WITHOUT multiplying the three numbers.
