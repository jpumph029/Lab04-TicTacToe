using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace XUnitTest_Lab04_TicTacToe
{
    public class UnitTest1
    {
        //test for winners
        [Fact]
        public void CanWin()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            p1.Marker = "X";
            p2.Marker = "O";
            Game game = new Game(p1, p2);
            game.Board.GameBoard[0, 0] = "O";
            game.Board.GameBoard[1, 0] = "O";
            game.Board.GameBoard[2, 0] = "O";
            Assert.True(game.CheckForWinner(game.Board));
        }
        [Fact]
        public void CanSwitchPlayers()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            p1.Marker = "X";
            p2.Marker = "O";
            Game game = new Game(p1, p2);
            game.SwitchPlayer();
            Assert.True(game.PlayerOne.IsTurn);
            game.SwitchPlayer();
            Assert.True(game.PlayerTwo.IsTurn);
        }
        [Fact]
        public void CorrelatesToTheCorrectIndexOfTheArray()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            p1.Marker = "X";
            p2.Marker = "O";
            Game game = new Game(p1, p2);
            Position pos1 = Player.PositionForNumber(1);
            Position pos2 = Player.PositionForNumber(2);
            game.Board.GameBoard[pos1.Row, pos1.Column] = p1.Marker;
            game.Board.GameBoard[pos2.Row, pos2.Column] = p2.Marker;
            Assert.Equal("X", game.Board.GameBoard[0, 0]);
            Assert.Equal("O", game.Board.GameBoard[0, 1]);
        }
        [Fact]
        public void CanDisplayGameBoard()
        { Board board = new Board();
            Assert.True(board.DisplayBoard());
        }
    }
}
