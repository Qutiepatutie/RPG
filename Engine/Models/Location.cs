using System.Windows.Media.Imaging;

namespace Engine.Models
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string? Name { get; set;}
        public string? Description { get; set;}
        public BitmapImage? ImageName { get; set;}
    }
}