using SportsLeagueTeamRankings.Models;
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

namespace SportsLeagueTeamRankings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private League _league;
        private List<Team> _teams;
        private List<Season> _seasons;
        private Configuration _configuration;
        private SeasonRankPoints _seasonRankPoints;
        private List<TeamStanding> _teamStandings;

        public MainWindow()
        {
            InitializeComponent();
            _league = new League();
            _teams = new List<Team>();
            _seasons = new List<Season>();
            _configuration = new Configuration();
            _seasonRankPoints = new SeasonRankPoints();
            _teamStandings = new List<TeamStanding>();
        }

        public League League => _league;
        public List<Team> Teams => _teams;
        public List<Season> Seasons => _seasons;
        public Configuration Configuration => _configuration;
        public SeasonRankPoints SeasonRankPoints => _seasonRankPoints;
        public List<TeamStanding> TeamStandings => _teamStandings;

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            ConfigurationWindow configurationWindow = new ConfigurationWindow();
            configurationWindow.Show();
        }
    }
}
