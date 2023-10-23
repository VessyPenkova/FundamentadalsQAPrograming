namespace _04010_Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            double average = 0.00;
            double result = 0.00;
            double grade = 0.0;
            int yearscounter = 0;
            int exludeCouner = 0;
            string output = "";
            bool graduated = true;
            while (yearscounter < 12)
            {
                grade = double.Parse(Console.ReadLine());
                yearscounter++;
                if (grade < 4.00)
                {
                    exludeCouner++;
                    if (exludeCouner >= 1)
                    {
                        output = $"{studentName} has been excluded at {yearscounter} grade";
                        graduated = false;
                        break;
                    }

                }
                else if (grade >= 4)
                {
                    result += grade;
                }
                average = result / yearscounter;

            }
            if (graduated is false)
            {
                output = $"{studentName} has been excluded at {yearscounter} grade";
            }
            else
            {
                graduated = true;
                output = $"{studentName} graduated. Average grade: {average:f2}";
            }
            Console.WriteLine(output);
        }
    }
}

//Write a program that calculates the average grade of a student throughout their education.
//On the first line, you will receive the student's name, and on each subsequent line,
//  you will receive their annual grades.
//A student advances to the next grade if their annual grade is greater than or equal to 4.00.
//If a student is failed more than once, they are expelled, and the program ends,
//printing the student's name and the grade in which they were expelled.
//Upon successful graduation from the 12th grade, print:
//"{student's name} graduated. Average grade: {average grade from the entire education}"
//In the case that a student is expelled from school, print:
//"{student's name} has been excluded at {grade in which they were expelled} grade"
//The value should be formatted to the second decimal place.