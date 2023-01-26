using NavalBattle_SharpCoders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle_SharpCoders.View
{
    public class BoardView
    {
        public static void ShowBoard(Piece[,] ocean)
        {
            for (int i = 0; i < 8; i++)
            {
                Console.Write(i);
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($" | {ocean[i,j].Simbol} |");
                }
                Console.WriteLine();
            }
            Console.WriteLine("    0     1     2     3     4     5     6     7");
        }
    }
}
