using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public char player;
        public char computer;
            public void InitializingBoard()
            {
            
                char[] board = new char[10];

                for (int i = 0; i < 10; i++)
                {
                    board[i] = ' ';
                }

            }
        public void ChooseYourOption()
        {
            Console.WriteLine("Choose the Option X or O");
            char input = Convert.ToChar(Console.ReadLine());
            if (input=='X')
            {
                player = 'X';
                computer = 'O';
            }
            if (input=='O')
            {
                computer = 'O';
                player = 'X';
            }
            else
                Console.WriteLine("Invalid Input");
        }
    }
}

