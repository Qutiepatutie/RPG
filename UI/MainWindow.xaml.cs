using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Engine.ViewModels;

namespace UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly GameSession _gameSession;
    
    public MainWindow()
    {
        InitializeComponent();

        _gameSession = new GameSession();

        DataContext = _gameSession; 
    }

    private void MoveNorth(object sender, RoutedEventArgs e)
    {
        _gameSession.MoveNorth();
    }
    private void MoveWest(object sender, RoutedEventArgs e)
    {
        _gameSession.MoveWest();
    }
    private void MoveEast(object sender, RoutedEventArgs e)
    {
        _gameSession.MoveEast();
    }
    private void MoveSouth(object sender, RoutedEventArgs e)
    {
        _gameSession.MoveSouth();
    }
}