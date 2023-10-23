namespace _05006_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int stepsCounter = 0;
            string command = Console.ReadLine();
            int diff = 0;
            int steps = 0;
            while (true)
            {
                if (command == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    stepsCounter += steps;
                    break;
                }
                else
                {
                    steps = int.Parse(command);
                    stepsCounter += steps;
                    if (stepsCounter >= goal)
                    {
                        break;
                    }
                }
                command = Console.ReadLine();
            }
            diff = Math.Abs(stepsCounter - goal);
            if (stepsCounter >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{diff} steps over the goal!");
                return;
            }
            else
            {
                Console.WriteLine($"{diff} more steps to reach goal.");
            }
        }
    }
}

//Gabi wants to start a healthy lifestyle and has set a goal to walk 10,000 steps every day.
//However, on some days, she feels very tired from work and wants to go home before reaching her goal.
//Write a program that reads from the console how many steps she takes each time she goes out during the day.
//When she reaches her goal,
//the program should display "Goal reached! Good job!" and how many steps she exceeded the goal by: "{difference} steps over the goal!"
//If she wants to go home before reaching her goal, she will enter the command "Going home" and input the steps she took while going home.
//After that, if she hasn't reached her goal, the program should display: "{difference} more steps to reach goal."