namespace _06004_Train_the_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            double allScore = 0;
            double counter = 0;

            while (true)
            {
                string nameOfPresentation = Console.ReadLine();
                double sumOfGrades = 0;

                if (nameOfPresentation == "Finish")
                {
                    double scoreSum = allScore / counter;
                    Console.WriteLine($"Student's final assessment is {scoreSum:f2}.");
                    break;
                }
                for (int i = 0; i < numberOfPeople; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                    allScore += grade;
                    counter++;
                }
                double sumAfter = sumOfGrades / numberOfPeople;
                Console.WriteLine($"{nameOfPresentation} - {sumAfter:f2}.");

            }
        }
    }
}

//The "Train the trainers" course is near its end, and the final assessment is approaching.
//Your task is to assist the jury that will evaluate the presentations by creating a program that
//calculates the average grade for each student's presentation and finally the overall average success.
//Read from the console, the number of jury members: n - an integer in the range[1…20]
//Then, the name of the presentation is read on a separate line: a string
//For each presentation, n grades are read on separate lines - real numbers in the range [2.00…6.00]
//After calculating the average grade for a specific presentation, print on the console:
//"{presentation name} - {average grade}."
//Upon receiving the command Finish, print on the console:
//"Student's final assessment is {overall average success}." and the program finishes. 
//All grades should be formatted to two decimal places.
