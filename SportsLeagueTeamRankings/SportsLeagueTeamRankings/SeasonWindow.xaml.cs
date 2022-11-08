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
using System.Windows.Shapes;

namespace SportsLeagueTeamRankings
{
    /// <summary>
    /// Interaction logic for SeasonWindow.xaml
    /// </summary>
    public partial class SeasonWindow : Window
    {
        public SeasonWindow()
        {
            InitializeComponent();
        }

        private void SubmitSeasonsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelSeasonsButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
