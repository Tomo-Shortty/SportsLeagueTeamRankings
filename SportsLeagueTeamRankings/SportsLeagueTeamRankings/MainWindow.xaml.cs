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
using System.Windows.Media.Animation;
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
        private List<SeasonRankPoints> _seasonRankPoints;
        private List<TeamStanding> _teamStandings;

        public static MainWindow Instance;

        public MainWindow()
        {
            InitializeComponent();
            _league = new League();
            _teams = new List<Team>();
            _seasons = new List<Season>();
            _configuration = new Configuration();
            _seasonRankPoints = new List<SeasonRankPoints>();
            _teamStandings = new List<TeamStanding>();
            Instance = this;
        }

        public League League { get { return _league; } set { _league = value; } }
        public List<Team> Teams { get { return _teams; } set { _teams = value; } }
        public List<Season> Seasons { get { return _seasons; } set { _seasons = value; } }
        public Configuration Configuration { get { return _configuration; } set { _configuration = value; } }
        public List<SeasonRankPoints> SeasonRankPoints { get { return _seasonRankPoints; } set { _seasonRankPoints = value; } }
        public List<TeamStanding> TeamStandings { get { return _teamStandings; } set { _teamStandings = value; } }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            ConfigurationWindow configurationWindow = new ConfigurationWindow();
            configurationWindow.Show();
        }

        public void CreateTeamStandingsTable(int numberOfRows, List<Team> teams)
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                StatsGrid.RowDefinitions.Add(new RowDefinition());

                var teamLabel = new Label();
                teamLabel.Name = "TeamLabel" + (i + 1).ToString();
                teamLabel.Content = teams[i].Name;
                teamLabel.FontSize = 16;
                teamLabel.HorizontalContentAlignment = HorizontalAlignment.Center;
                teamLabel.VerticalContentAlignment = VerticalAlignment.Center;
                StatsGrid.Children.Add(teamLabel);
                Grid.SetColumn(teamLabel, 0);
                Grid.SetRow(teamLabel, StatsGrid.RowDefinitions.Count - 1);

                var rankLabel = new Label();
                rankLabel.Name = "RankLabel" + (i + 1).ToString();
                rankLabel.Content = teams[i].Rank;
                rankLabel.FontSize = 16;
                rankLabel.HorizontalContentAlignment = HorizontalAlignment.Center;
                rankLabel.VerticalContentAlignment = VerticalAlignment.Center;
                StatsGrid.Children.Add(rankLabel);
                Grid.SetColumn(rankLabel, 1);
                Grid.SetRow(rankLabel, StatsGrid.RowDefinitions.Count - 1);

                var pointsLabel = new Label();
                pointsLabel.Name = "PointsLabel" + (i + 1).ToString();
                pointsLabel.Content = teams[i].Rank;
                pointsLabel.FontSize = 16;
                pointsLabel.HorizontalContentAlignment = HorizontalAlignment.Center;
                pointsLabel.VerticalContentAlignment = VerticalAlignment.Center;
                StatsGrid.Children.Add(pointsLabel);
                Grid.SetColumn(pointsLabel, 2);
                Grid.SetRow(pointsLabel, StatsGrid.RowDefinitions.Count - 1);

                var border = new Border();
                var borderBrush = new SolidColorBrush(Colors.Black);
                var borderThickness = new Thickness(0, 0, 0, 1);
                border.BorderBrush = borderBrush;
                border.BorderThickness = borderThickness;
                StatsGrid.Children.Add(border);
                Grid.SetColumnSpan(border, 3);
                Grid.SetRow(border, StatsGrid.RowDefinitions.Count - 1);
            }
        }

        public void RemoveTeamStandingsTable(int lastRowCount)
        {
            StatsGrid.RowDefinitions.RemoveRange(1, lastRowCount);
        }
    }
}
