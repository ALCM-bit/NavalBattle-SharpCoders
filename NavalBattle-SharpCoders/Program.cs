
using NavalBattle_SharpCoders.Models;
using NavalBattle_SharpCoders.View;

Console.WriteLine("Hello, World!");

Player player1 = new Player("Felipe", "12345");
Player player2 = new Player("Pedro", "12345");

Board board = new Board(player1, player2);
board.StartBoard();
BoardView.ShowBoard(board._ocean);
Console.WriteLine("Fim....");
Console.ReadKey();
