namespace _06003_Sum_of_Prime_and_Non_Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumPrimeNumbers = 0;
            int sumNonPrimeNumbers = 0;

            string command = Console.ReadLine();
            while (command != "stop")
            {
                int number = int.Parse(command);
                int divisors = 0;
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {

                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            divisors++;
                        }
                    }
                    if (divisors == 2)
                    {
                        sumPrimeNumbers += number;
                    }
                    else
                    {
                        sumNonPrimeNumbers += number;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNumbers}");
        }
    }
}

//Write a program that reads integer numbers from the console until the command "stop" is received.
//Find the sum of all entered prime numbers and the sum of all entered non-prime numbers.
//As per mathematical definition, negative numbers cannot be prime.
//If a negative number is entered, display the message "Number is negative."
//In this case, ignore the entered number and do not add it to either of the two sums. The program continues its execution,
//awaiting the input of the next number.
//To determine if a number is prime, we can use the following algorithm: