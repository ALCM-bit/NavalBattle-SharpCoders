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
        public Player player1 { get; set; }
        public Player player2 { get; set; }

        public Board()
        {

        }
        public Board(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void StartBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    _ocean[i, j] = new Nothing(i,j);
                }

            }
        }

        
    }
}
