using SportsLeagueTeamRankings.Constants;
using SportsLeagueTeamRankings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SportsLeagueTeamRankings.Services
{
    public static class CalculationService
    {
        public static void GenerateSeasonTabs(List<Season> seasons, TabControl tabControl, ListBoxItem listBoxItem)
        {
            tabControl.Items.Clear();

            foreach (var season in seasons)
            {
                var tabItem = new TabItem();
                tabItem.Header = season.Name;
                tabItem.Tag = season;
                tabControl.Items.Add(tabItem);
            }
        }

        private static void GenerateTabContent(TabControl tabControl, ListBoxItem listBoxItem)
        {
            foreach (TabItem tabItem in tabControl.Items)
            {
                var grid = new Grid();
                var rows = 6;
                var columns = 2;

                for (int i = 0; i < rows; i++)
                {
                    grid.RowDefinitions.Add(new RowDefinition());
                }

                for (int i = 0; i < columns; i++)
                {
                    grid.ColumnDefinitions.Add(new ColumnDefinition());
                }

                tabItem.Content = grid;
            }
        }

        private static void GenerateLabels(Grid grid, TabItem tabItem, ListBoxItem listBoxItem)
        {
            var titleLabel = new Label();
            titleLabel.Content = listBoxItem.Content + " " + tabItem.Header;
            titleLabel.FontSize = 24;
            titleLabel.FontWeight = FontWeights.Bold;
            titleLabel.HorizontalAlignment = HorizontalAlignment.Left;
            titleLabel.VerticalAlignment = VerticalAlignment.Center;
            titleLabel.Padding = new Thickness(10, 0, 0, 0);
            grid.Children.Add(titleLabel);
            Grid.SetColumn(titleLabel, 0);
            Grid.SetRow(titleLabel, 0);

            var seasonRankLabel = new Label();
            SetLabelProperties(seasonRankLabel, CalculationItemStrings.SeasonRankLabel, grid, 0, 1);

            var leaguePointsLabel = new Label();
            SetLabelProperties(leaguePointsLabel, CalculationItemStrings.LeaguePointsLabel, grid, 1, 1);

            var pointsDifferenceLabel = new Label();
            SetLabelProperties(pointsDifferenceLabel, CalculationItemStrings.PointsDifferenceLabel, grid, 0, 2);
        }

        private static void SetLabelProperties(Label label, string content, Grid grid, int column, int row)
        {
            label.Content = content;
            label.FontSize = 12;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.VerticalAlignment = VerticalAlignment.Center;
            label.Padding = new Thickness(10, 0, 0, 0);
            grid.Children.Add(label);
            Grid.SetColumn(label, column);
            Grid.SetRow(label, row);
        }
    }
}
