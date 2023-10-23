namespace _05004_Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failedtry = int.Parse(Console.ReadLine());
            int failedTime = 0;
            int solverProblems = 0;
            double gradeSum = 0;
            string lastProblem = string.Empty;
            bool isFailed = true;
            while (failedTime < failedtry)
            {
                string taskName = (Console.ReadLine());
                if ("Enough" == taskName)
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTime++;
                }
                gradeSum += grade;
                solverProblems++;
                lastProblem = taskName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedtry} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum / solverProblems:f2}");
                Console.WriteLine($"Number of problems: {solverProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}

//Input
//•	On the first line - number of poor grades - an integer in the range [1…5]
//•	After that, read multiple pairs of lines:
//o Problem name - text (string)
//o Grade - an integer in the range [2…6]
//Output
//•	If Marin reaches the command "Enough," print on 3 lines:
//o "Average score: {average grade}"
//o "Number of problems: {total number of problems}"
//o "Last problem: {name of the last problem}"
//•	If he receives the specified number of poor grades:
//o "You need a break, {number of poor grades} poor grades."
//Format the average grade to have two decimal places after the decimal point.
