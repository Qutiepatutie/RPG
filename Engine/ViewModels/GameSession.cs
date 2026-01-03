using System.Windows.Media.Imaging;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
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

            CurrLocation = new Location();
            CurrLocation.Name = "Home";
            CurrLocation.X = 0;
            CurrLocation.Y = 0;
            CurrLocation.Description = "This is your house";
            CurrLocation.ImageName = new BitmapImage(new Uri("pack://application:,,,/Engine;component/Assets/Locations/Home.png", UriKind.Absolute));
        }
    }
}