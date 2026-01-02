using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrPlayer { get; set; }

        public GameSession()
        {
            CurrPlayer = new Player();
            CurrPlayer.Name = "Player";
            CurrPlayer.Class = "Assassin";
            CurrPlayer.HP = 10;
            CurrPlayer.EXP = 0;
            CurrPlayer.Level = 1;
            CurrPlayer.Gold = 1000000;
        }
    }
}