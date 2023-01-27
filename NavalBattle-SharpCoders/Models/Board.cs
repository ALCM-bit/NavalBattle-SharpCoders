using NavalBattle_SharpCoders.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle_SharpCoders.Models
{
    public class Board
    {
        public Piece[,] _ocean = new Piece[8,8];
        public Piece[,] _ocean2 = new Piece[8, 8];
        public Player player1 { get; set; }
        public Player player2 { get; set; }
        public static int Time { get; private set; }

        public Board()
        {

        }
        public Board(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void StartBoards()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    _ocean[i, j] = new Ship(i,j);
                }

            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    _ocean2[i, j] = new Ship(i, j);
                }

            }

            PlaceShipsOcean1();
            PlaceShipsOcean2();
        }

        public bool SelectPiece(Piece[,] ocean, int line, int column)
        {
            if (ocean[line, column].Hidden == false)
            {
                ocean[line, column].Simbol = 'X';
                Time++;
                return false;

            }

            else
            {
                ocean[line, column].Simbol = 'N';
                return true;
            }

        }

        public void PlaceShipsOcean1()
        {
            Random randomLine = new Random();
            Random randomColumn = new Random();
            for (int i = 0; i < 5; i++)
            {
                _ocean[randomLine.Next(7),randomColumn.Next(7)].Hidden = true;
            }
        }
        public void PlaceShipsOcean2()
        {
            Random randomLine = new Random();
            Random randomColumn = new Random();
            for (int i = 0; i < 5; i++)
            {
                _ocean2[randomLine.Next(7), randomColumn.Next(7)].Hidden = true;
            }
        }

        public static int CheckTime()
        {
            if (Time %2 == 0)
                return 1;
            else
                return 0;
        }
    }
}
