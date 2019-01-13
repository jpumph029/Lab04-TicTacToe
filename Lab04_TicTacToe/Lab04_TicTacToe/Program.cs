using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            //new players and their markers
            Player p1 = new Player();
            Player p2 = new Player();
            p1.Marker = "X";
            p2.Marker = "O";

            //player one picks their name
            Console.Write("Player one write your name: ");
            string userInput1 = Console.ReadLine();
            p1.Name = userInput1;

            // player two picks their name
            Console.Write("Player two write your name: ");
            string userInput2 = Console.ReadLine();
            p2.Name = userInput2;

            // initialize new game
            Game game = new Game(p1, p2);
            game.Play();
        }
        public static int counter = 0;
    }
}
