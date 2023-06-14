using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cards
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Refresh(true);
        }
        private void Refresh(bool isUp)
        {
            var teams = App.DB.Team.ToList();
            if(isUp)
                teams = teams.OrderBy(t => t.TeamName).ToList();
            if(isUp == false)
                teams = teams.OrderByDescending(t => t.TeamName).ToList();
            LVTeams.ItemsSource = teams;
        }
        private void BUp_Click(object sender, RoutedEventArgs e)
        {
            Refresh(true);
        }

        private void BDown_Click(object sender, RoutedEventArgs e)
        {
            Refresh(false);
        }
    }
}
