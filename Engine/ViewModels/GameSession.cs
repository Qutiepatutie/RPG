using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrWorld { get; set; }
        public Player? CurrPlayer { get; set; }
        public Location? CurrLocation { get; set; }

        public GameSession()
        {
            CurrPlayer = new Player();
            CurrPlayer.Name = "Player";
            CurrPlayer.Class = "Assassin";
            CurrPlayer.HP = 10;
            CurrPlayer.EXP = 0;
            CurrPlayer.Level = 1;
            CurrPlayer.Gold = 1000000;

            WorldFactory factory = new WorldFactory();
            CurrWorld = factory.CreateWorld();

            CurrLocation = CurrWorld.LocationAt(0,0);
        }
    }
}