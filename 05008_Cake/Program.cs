namespace _05008_Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int areaofThecace = width * lenght;
            int tookedPiecesOfThecaceCounter = 0;
            int piecesLeft = 0;

            string command = Console.ReadLine();

            while (command != "STOP")
            {
                tookedPiecesOfThecaceCounter = int.Parse(command);

                areaofThecace -= tookedPiecesOfThecaceCounter;

                if (areaofThecace < 0)
                {
                    areaofThecace = areaofThecace * -1;

                    Console.WriteLine($"No more cake left! You need {areaofThecace} pieces more.");

                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "STOP")
            {

                if (areaofThecace < 0)
                {
                    Console.WriteLine($"No more cake left! You need {areaofThecace} pieces more.");
                }
                else if (areaofThecace > 0)
                {
                    Console.WriteLine($"{areaofThecace} pieces are left.");
                }
                else if (areaofThecace == 0)
                {
                    Console.WriteLine($"{areaofThecace} pieces are left.");
                }
            }
        }
    }
}

//You are invited to a 30th birthday party where the birthday person is having a large cake.
//However, they don't know how many pieces the guests can take before the cake is finished.
//Your task is to write a program that calculates the number of pieces guests have taken before the cake runs out.
//You will receive the dimensions of the cake (width and length - integers in the range [1...1000]),
//and then on each line, until you receive the command "STOP" or until the cake is finished,
//you will get the number of pieces guests take from it.

//Note: Each cake piece has a size of 1x1 cm.
//Print one of the following lines on the console:
//"{number of pieces} pieces are left." - if you reach STOP and there are cake pieces left
//"No more cake left! You need {number of missing pieces} pieces more."
