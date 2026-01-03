using System.ComponentModel;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession : INotifyPropertyChanged
    {
        private Location? _currLocation;

        public World CurrWorld { get; set; }
        public Player? CurrPlayer { get; set; }
        public Location? CurrLocation
        {
            get { return _currLocation; }
            set
            { 
                _currLocation = value;
                OnPropChange("CurrLocation");    
                OnPropChange("HasLocToNorth");
                OnPropChange("HasLocToWest");
                OnPropChange("HasLocToEast");
                OnPropChange("HasLocToSouth");
            }
        }

        public bool HasLocToNorth
        {
            get 
            { 
                return CurrWorld.LocationAt(CurrLocation.X, CurrLocation.Y + 1)  != null;
            }
        }

        public bool HasLocToWest
        {
            get 
            { 
                return CurrWorld.LocationAt(CurrLocation.X - 1, CurrLocation.Y)  != null;
            }
        }

        public bool HasLocToEast
        {
            get 
            { 
                return CurrWorld.LocationAt(CurrLocation.X + 1, CurrLocation.Y)  != null;
            }
        }

        public bool HasLocToSouth
        {
            get 
            { 
                return CurrWorld.LocationAt(CurrLocation.X, CurrLocation.Y - 1)  != null;
            }
        }

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

        public void MoveNorth()
        {
            CurrLocation = CurrWorld.LocationAt(CurrLocation.X, CurrLocation.Y + 1);
        } 

        public void MoveWest()
        {
            CurrLocation = CurrWorld.LocationAt(CurrLocation.X - 1, CurrLocation.Y);

        } 

        public void MoveEast()
        {
            CurrLocation = CurrWorld.LocationAt(CurrLocation.X + 1, CurrLocation.Y);

        } 

        public void MoveSouth()
        {
            CurrLocation = CurrWorld.LocationAt(CurrLocation.X, CurrLocation.Y - 1);

        } 

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropChange(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}