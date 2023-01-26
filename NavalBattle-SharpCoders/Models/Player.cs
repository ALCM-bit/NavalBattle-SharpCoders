namespace NavalBattle_SharpCoders.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Points { get; set; }

        public Player(string name, string password) 
        {
            Name = name;
            Password = password;
        }
    }
}