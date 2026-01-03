using System.Windows.Media.Imaging;
using System.Collections.Generic;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int x, int y, string name, string description, BitmapImage imageName)
        {
            Location loc = new Location();
            loc.X = x;
            loc.Y = y;
            loc.Name = name;
            loc.Description = description;
            loc.ImageName = imageName;

            _locations.Add(loc);
        }

        public Location? LocationAt(int x, int y)
        {
            foreach(Location loc in _locations)
            {
                if(loc.X == x && loc.Y == y)
                {
                    return loc;
                }
            }

            return null;
        }
    }
}