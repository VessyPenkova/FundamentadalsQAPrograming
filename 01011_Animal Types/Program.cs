using System.Runtime.Intrinsics.X86;

namespace _01011_Animal_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string annimal = Console.ReadLine();
            if (annimal == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (annimal == "crocodile" || annimal == "tortoise" || annimal == "snake" )
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}

//2.Classify The Animal: Use a switch statement to match the input value with the corresponding animal type. 
//3.	Check the following conditions:
//•	If the animal is "dog", display "mammal" on the console.
//•	If the animal is "crocodile", "tortoise", or "snake", display "reptile" on the console.
//•	If none of the above cases match, display "unknown" on the console.
