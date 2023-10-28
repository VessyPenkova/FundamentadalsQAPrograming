using System.Collections.Generic;

namespace _18006S_Cards_Game_Arrays_Lists_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> player2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            while (player1.Count >0 && player2.Count >0)
            {              
                if (player1[0] > player2[0])
                {
                    player1.Add(player2[0]);
                    player1.Add(player1[0]);               
                }
                else if (player1[0] < player2[0])
                {
                    player2.Add(player1[0]);
                    player2.Add(player2[0]);
                }
                player1.RemoveAt(0);
                player2.RemoveAt(0);
            }
            if (player1.Count >0)
            {
                int sum = player1.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (player2.Count > 0)
            {
                int sum = player2.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}

//You will be given two hands of cards, which will be integer numbers. Assume that you have two players.
//You must find the winning deck and, respectively, the winner.
//You start from the beginning of both hands.
//Compare the cards from the first deck to those from the second.
//The player, who has a bigger card, takes both cards and puts them on the back of his hand - the second player's card is last, and the first person's card (the winning one) is before it (second to last), and the player with the smaller card must remove the card from his deck. If both players' cards have the same values - no one wins, and the two cards must be removed from the decks. 
//The game is over when one of the decks is left without any cards. You have to print the winner on the console and the sum of the left cards: 
//"{First/Second} player wins! Sum: {sum}".
