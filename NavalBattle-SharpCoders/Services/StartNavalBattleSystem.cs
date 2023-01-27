using NavalBattle_SharpCoders.Models;
using NavalBattle_SharpCoders.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle_SharpCoders.Services
{
    public class StartNavalBattleSystem
    {
        public static void StartGame()
        {
            Player player1 = new Player("Felipe", "12345");
            Player player2 = new Player("Pedro", "12345");

            Board board = new Board(player1, player2);
            board.StartBoards();
            while (true)
            {
                if (Board.CheckTime() == 1)
                {
                    BoardView.ShowBoard(board._ocean);
                    Console.WriteLine($"Vez de: {player1.Name}");
                    BoardView.PlaceSelection(board._ocean, board);
                }
                else
                {
                    BoardView.ShowBoard(board._ocean2);
                    Console.WriteLine($"Vez de: {player2.Name}");
                    BoardView.PlaceSelection(board._ocean2, board);
                }
                
                
            }
            

        }

    }
}
