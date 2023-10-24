namespace _10006_Exam_Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 0; i --)
            {
                if (i == 0)
                {
                    Console.WriteLine("The exam has come");
                }
                else
                {
                    Console.WriteLine($"{i} days before the exam");
                }
                
            }
        }
    }
}

//Write a program to print a countdown to an exam:
//•	Read an integer number d: the count of days before an exam
//•	For each day d…1 print: "{currentDay} days before the exam"
//•	At the end print: "The exam has come"
