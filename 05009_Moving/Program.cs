namespace _05009_Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * height * length;
            string command = Console.ReadLine();
            while (true)
            {
                if (command == "Done")
                {
                    Console.WriteLine($"{volume} Cubic meters left.");
                    break;
                }
                int numberOfBoxes = int.Parse(command);
                if (numberOfBoxes > volume)
                {
                    Console.WriteLine($"No more free space! You need {numberOfBoxes - volume} Cubic meters more.");
                    break;
                }
                volume -= numberOfBoxes;
                command = Console.ReadLine();
            }
        }
    }
}

//9.Moving Out
//On his eighteenth birthday, Jose decided to move out and rent an apartment.
//He packed his belongings in boxes and found a suitable apartment rental ad.
//He starts moving his luggage in parts, as he can't move everything at once.
//There is limited free space in his new apartment where he can arrange his belongings, so that the space is suitable for living.
//Write a program that calculates the free volume of Jose's apartment after he moves his luggage.
//Note: One box has exact dimensions: 1m x 1m x 1m.
//Input
//The user enters the following data on separate lines
//1.	Width of the free space - an integer in the range [1...1000]
//2.Length of the free space - an integer in the range [1...1000]
//3.Height of the free space - an integer in the range [1...1000]
//4.On the following lines (until receiving the command "Done") -the number of boxes being moved into the apartment - an integer in the range [1...10000]
//The program should stop reading data when the command "Done" is entered or when the free space runs out.
//Output
