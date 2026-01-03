using System.Windows.Media.Imaging;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation
            (
                0, // X
                0, // Y
                "Home", // Name
                "This is your home.", // Description
                new BitmapImage(
                        new Uri(
                            "pack://application:,,,/Engine;component/Assets/Locations/Home.png", UriKind.Absolute // Image name
                            )
                        )
            );
            newWorld.AddLocation
            (
                -1, // X
                0, // Y
                "Farmer's House", // Name
                "This is the house of your neighbor, Farmer Ted.", // Description
                new BitmapImage(
                        new Uri(
                            "pack://application:,,,/Engine;component/Assets/Locations/FarmHouse.png", UriKind.Absolute // Image name
                            )
                        )
            );
            newWorld.AddLocation
            (
                -2, // X
                0, // Y
                "Farmer's Field", // Name
                "There are rows of corn growing here, with giant rats hiding between them.", // Description
                new BitmapImage(
                        new Uri(
                            "pack://application:,,,/Engine;component/Assets/Locations/FarmFields.png", UriKind.Absolute // Image name
                            )
                        )
            );
            newWorld.AddLocation
            (
                -1, // X
                1, // Y
                "Trading Shop", // Name
                "The shop of Susan, the trader.", // Description
                new BitmapImage(
                        new Uri(
                            "pack://application:,,,/Engine;component/Assets/Locations/Trader.png", UriKind.Absolute // Image name
                            )
                        )
            );
            newWorld.AddLocation
            (
                0, // X
                1, // Y
                "Town Square", // Name
                "You see a fountain here.", // Description
                new BitmapImage(
                        new Uri(
                            "pack://application:,,,/Engine;component/Assets/Locations/TownSquare.png", UriKind.Absolute // Image name
                            )
                        )
            );
            newWorld.AddLocation
            (
                1, // X
                1, // Y
                "Town Gate", // Name
                "There is a gate here, protecting the town from giant spiders.", // Description
                new BitmapImage(
                        new Uri(
                            "pack://application:,,,/Engine;component/Assets/Locations/TownGate.png", UriKind.Absolute // Image name
                            )
                        )
            );
            newWorld.AddLocation
            (
                2, // X
                1, // Y
                "Spider Forest", // Name
                "The trees in this forest are covered with spider webs.", // Description
                new BitmapImage(
                        new Uri(
                            "pack://application:,,,/Engine;component/Assets/Locations/SpiderForest.png", UriKind.Absolute // Image name
                            )
                        )
            );
            newWorld.AddLocation
            (
                0, // X
                2, // Y
                "Herbalist's Hut", // Name
                "You see a small hut, with plants drying from the roof.", // Description
                new BitmapImage(
                        new Uri(
                            "pack://application:,,,/Engine;component/Assets/Locations/HerbalistsHut.png", UriKind.Absolute // Image name
                            )
                        )
            );
            newWorld.AddLocation
            (
                0, // X
                3, // Y
                "Herbalist's Garden", // Name
                "There are many plants here, with snakes hiding behind them.", // Description
                new BitmapImage(
                        new Uri(
                            "pack://application:,,,/Engine;component/Assets/Locations/HerbalistsGarden.png", UriKind.Absolute // Image name
                            )
                        )
            );
            return newWorld;
        }
    }
}