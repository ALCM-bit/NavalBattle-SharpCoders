namespace NavalBattle_SharpCoders.Models
{
    public abstract class Piece
    {
        public char Simbol { get; private set; }
        public bool Hidden { get; set; }
        public int Line { get; private set; }
        public int Column { get; private set; }

        public Piece(int line, int column)
        {
            Hidden = false;
            Simbol = '~';
            Line = line;
            Column = column;
        }
        

    }
}