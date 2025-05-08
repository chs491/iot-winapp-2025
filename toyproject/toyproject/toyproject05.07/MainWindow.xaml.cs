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
using toyproject05._07.PlayerApp.Data;

namespace toyproject05._07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            dgPlayers.ItemsSource = Database.GetAllPlayers().ToList();
        }

        private void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            var player = new Player
            {
                Name = txtName.Text,
                Position = txtPosition.Text,
                Age = int.Parse(txtAge.Text)
            };

            Database.AddPlayer(player);
            LoadPlayers();

            txtName.Clear();
            txtPosition.Clear();
            txtAge.Clear();
        }
    }
}