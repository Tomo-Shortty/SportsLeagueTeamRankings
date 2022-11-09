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
    /// Interaction logic for SeasonWindow.xaml
    /// </summary>
    public partial class SeasonWindow : Window
    {
        private List<TextBox> _textBoxes;

        public SeasonWindow()
        {
            InitializeComponent();
            _textBoxes = new List<TextBox>();
        }

        private void SubmitSeasonsButton_Click(object sender, RoutedEventArgs e)
        {
            var result = true;
            var offendingTextBox = new TextBox();
            ListService.ClearList(ConfigurationWindow.Instance.Seasons);

            foreach (TextBox textBox in _textBoxes)
            {
                if (textBox.Text.Equals(""))
                {
                    result = false;
                    offendingTextBox = textBox;
                    break;
                }
                else
                {
                    ConfigurationWindow.Instance.Seasons.Add(textBox.Text.Trim());
                }
            }

            if (!result)
            {
                MessageBox.Show(offendingTextBox.Name.ToString() + " does not have a name. Please provide a name for this team.");
                ListService.ClearList(ConfigurationWindow.Instance.Seasons);
            }
            else
            {
                ConfigurationWindow.Instance.SeasonsListTextBox.Text = ListService.WriteElementsToStringSingleLine(ConfigurationWindow.Instance.Seasons);
                Close();
            }
        }

        private void CancelSeasonsButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void SetNumberOfRows(int numberOfRows)
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                ViewSeasonsGrid.RowDefinitions.Add(new RowDefinition());
                var textBox = new TextBox();
                textBox.Name = "Season" + (i + 1).ToString();
                textBox.Text = "";
                textBox.Width = 180;
                textBox.Height = 20;
                textBox.HorizontalContentAlignment = HorizontalAlignment.Center;
                textBox.VerticalContentAlignment = VerticalAlignment.Center;
                ViewSeasonsGrid.Children.Add(textBox);
                Grid.SetRow(textBox, ViewSeasonsGrid.RowDefinitions.Count - 1);
                _textBoxes.Add(textBox);
            }
        }
    }
}
