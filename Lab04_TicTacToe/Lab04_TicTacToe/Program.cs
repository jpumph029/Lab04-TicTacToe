using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player();
            //player once picks their name
            Console.Write("Player one write your name: ");
            string userInput1 = Console.ReadLine();
            userInput1 = p1.Name;

            // player two picks their name
            Console.Write("Player Two write your name: ");
            string userInput2 = Console.ReadLine();
            userInput2 = p2.Name;
            // init new game
            Game game = new Game(p1, p2);
            game.Play();
        }
    }
}
