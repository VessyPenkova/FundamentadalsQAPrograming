namespace _15006_Vowels_Count__Exercise_Nested_Loops_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            GetVowelsCount(text);
        }

        private static void GetVowelsCount(string text)
        {
            char[] vowels = { 'A', 'a', 'O', 'o', 'U', 'u', 'I', 'i' };
            int wavelCounter = 0;
            for (int i = 0; i <= text.Length - 1; i++)
            {
                if (vowels.Contains(text[i]))
                {
                    wavelCounter++;
                }
            }
        }
    }
}

//Write a program that:
//•	Read a text (string) from the console
//•	Create a method that receives a text
//•	Find the count of the vowels contained in the text
//•	Print the count of the vowels in the text
