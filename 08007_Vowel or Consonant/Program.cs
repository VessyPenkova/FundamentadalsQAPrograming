namespace _08007_Vowel_or_Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] vowels = {"A", "a", "E", "e", "I", "i", "O", "o", "U", "u" };

            string input = Console.ReadLine();

            if (vowels.Contains(input))
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}

//Write a program to check a letter for vowel or consonant:
//•	Reads a character (letter, part of the English alphabet) from the console
//•	Based on the value of the character, print:
// -    If the character is vowel letter print "Vowel"

//Hint: Vowels letters are: A, a, E, e, I, i, O, o, U, u

// - 	If the character is consonant letter print "Consonant"
