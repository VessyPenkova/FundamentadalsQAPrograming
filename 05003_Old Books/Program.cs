namespace _05003_Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoritebook = Console.ReadLine();
            int counter = 0;
            bool isBookFound = false;
            string nextBook = Console.ReadLine();
            while (nextBook != "No More Books")
            {
                if (nextBook == favoritebook)
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                nextBook = Console.ReadLine();
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}

//Annie returns to her hometown after a very long period abroad.
//Upon returning home, she sees her grandmother's old library and remembers her favorite book.
//Help Annie by writing a program, where she enters the title of the book she's looking for (text).
//Until Ani doesn't find her favorite book or doesn't check all the books in the library,
//The program should read the name of the next book (text) on a new line.When you receive the text "No More Books", then all the books are checked.
//• If Annie doesn't find the book she's looking for, print two lines:
//o "The book you search is not here!"
//o "You checked {number} books."
//• If she finds the book, print one line:
//	o "You checked {number} books and found it."