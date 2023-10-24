namespace _07005_Guess_the_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string password = Console.ReadLine();
            if (password == "s3cr3t!")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}

//Write a program for checking a password, which:
//Reads a string that holds a password
//Prints "Welcome" if the password is "s3cr3t!"
//Prints "Wrong password!" in all other cases 
