using SportsLeagueTeamRankings.Enums;
using SportsLeagueTeamRankings.Models;
using SportsLeagueTeamRankings.Services;
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
    /// Interaction logic for ConfigurationWindow.xaml
    /// </summary>
    
    public partial class ConfigurationWindow : Window
    {
        private bool _leagueNameEntered = false;
        private bool _numberOfTeamsEntered = false;
        private bool _numberOfSeasonsEntered = false;
        private List<string> _teams;
        private List<string> _seasons;

        public static ConfigurationWindow Instance;

        public ConfigurationWindow()
        {
            InitializeComponent();
            _teams = new List<string>();
            _seasons = new List<string>();
            Instance = this;
        }

        public List<string> Teams => _teams;
        public List<string> Seasons => _seasons;

        private void LeagueNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!LeagueNameTextBox.Text.Equals(""))
            {
                _leagueNameEntered = true;
                if (_numberOfTeamsEntered)
                {
                    TeamsConfigurationButton.IsEnabled = true;
                }
            } 
            else
            {
                _leagueNameEntered = false;
                if (TeamsConfigurationButton.IsEnabled)
                {
                    TeamsConfigurationButton.IsEnabled = false;
                }
            }
        }

        private void LeagueSetupCompetitionTypeSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LeagueSetupCompetitionTypeSelector.SelectedIndex == 2)
            {
                TeamsPerDivisionLabel.Visibility = Visibility.Visible;
                TeamsPerDivisionTextBox.Visibility = Visibility.Visible;
                TeamsPerDivisionTextBox.IsEnabled = true;
            }
            else
            {
                TeamsPerDivisionLabel.Visibility = Visibility.Collapsed;
                TeamsPerDivisionTextBox.Visibility = Visibility.Collapsed;
                TeamsPerDivisionTextBox.IsEnabled = false;
            }
        }

        private void NumberOfTeamsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!NumberOfTeamsTextBox.Text.Equals(""))
            {
                _numberOfTeamsEntered = true;
                if (_leagueNameEntered)
                {
                    TeamsConfigurationButton.IsEnabled = true;
                }
            }
            else
            {
                _numberOfTeamsEntered = false;
                if (TeamsConfigurationButton.IsEnabled)
                {
                    TeamsConfigurationButton.IsEnabled = false;
                }
            }
        }

        private void TeamsConfigurationButton_Click(object sender, RoutedEventArgs e)
        {
            TeamWindow teamWindow = new TeamWindow();
            teamWindow.Title = LeagueNameTextBox.Text.Trim() + " Teams";
            teamWindow.SetNumberOfRows(int.Parse(NumberOfTeamsTextBox.Text.Trim()));
            teamWindow.Show();
        }

        private void NumberOfSeasonsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!NumberOfSeasonsTextBox.Text.Equals(""))
            {
                _numberOfSeasonsEntered = true;
                SeasonsConfigurationButton.IsEnabled = true;
            }
            else
            {
                _numberOfSeasonsEntered = false;
                SeasonsConfigurationButton.IsEnabled = false;
            }
        }

        private void SeasonsConfigurationButton_Click(object sender, RoutedEventArgs e)
        {
            SeasonWindow seasonWindow = new SeasonWindow();
            seasonWindow.Show();
        }

        private void IncludeSecondaryPlayOffRankCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            SecondaryPlayOffRankTextBox.IsEnabled = true;
        }

        private void IncludeSecondaryPlayOffRankCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            SecondaryPlayOffRankTextBox.IsEnabled = false;
        }

        private void SubmitConfigurationButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ResetConfigurationButton_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void CancelConfigurationButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Reset()
        {
            LeagueNameTextBox.Text = "";
            LeagueSetupCompetitionTypeSelector.SelectedIndex = 0;
            TeamsPerDivisionTextBox.Text = "";
            NumberOfTeamsTextBox.Text = "";
            TeamsConfigurationButton.IsEnabled = false;
            _leagueNameEntered = false;
            _numberOfTeamsEntered = false;
            ListService.ClearList(_teams);
            ListService.ClearList(_seasons);
            NumberOfSeasonsTextBox.Text = "";
            SeasonsConfigurationButton.IsEnabled = false;
            _numberOfSeasonsEntered = false;
            PlayOffWinTextBox.Text = "5";
            PreliminaryFinalAppearanceTextBox.Text = "5";
            GrandFinalAppearanceTextBox.Text = "5";
            PremiershipTextBox.Text = "10";
            BackToBackPremiershipWinTextBox.Text = "10";
            WoodenSpoonTextBox.Text = "-10";
            PointsDifferenceDivisionTextBox.Text = "10";
            PlayOffRankTextBox.Text = "8";
            IncludeSecondaryPlayOffRankCheckbox.IsChecked = true;
            SecondaryPlayOffRankTextBox.IsEnabled = true;
            SecondaryPlayOffRankTextBox.Text = "4";
            TakeAverageScoreForMissingYearsCheckbox.IsChecked = false;
            ExcellentScoreTextBox.Text = "400";
            GoodScoreTextBox.Text = "300";
            AverageScoreTextBox.Text = "200";
            BadScoreTextBox.Text = "100";
            TerribleScoreTextBox.Text = "0";
        }
    }
}
