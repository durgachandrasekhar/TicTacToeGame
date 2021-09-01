using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to Tic-Tac-Toe Game");
            TicTacToeGame tictactoegame = new TicTacToeGame();
            tictactoegame.InitializingBoard();
        }


    }

}