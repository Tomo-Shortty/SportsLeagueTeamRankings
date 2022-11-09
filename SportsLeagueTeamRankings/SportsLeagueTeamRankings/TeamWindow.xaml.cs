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
    /// Interaction logic for TeamWindow.xaml
    /// </summary>
    public partial class TeamWindow : Window
    {
        private List<TextBox> _textBoxes;

        public TeamWindow()
        {
            InitializeComponent();
            _textBoxes = new List<TextBox>();
        }

        private void SubmitTeamsButton_Click(object sender, RoutedEventArgs e)
        {
            var result = true;
            var offendingTextBox = new TextBox();
            ListService.ClearList(ConfigurationWindow.Instance.Teams);

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
                    ConfigurationWindow.Instance.Teams.Add(textBox.Text.Trim());
                }
            }
            
            if (!result)
            {
                MessageBox.Show(offendingTextBox.Name.ToString() + " does not have a name. Please provide a name for this team.");
                ListService.ClearList(ConfigurationWindow.Instance.Teams);
            }
            else
            {
                ConfigurationWindow.Instance.TeamsListTextBox.Text = ListService.WriteElementsToStringSingleLine(ConfigurationWindow.Instance.Teams);
                Close();
            }
        }

        private void CancelTeamsButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void SetNumberOfRows(int numberOfRows)
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                ViewTeamsGrid.RowDefinitions.Add(new RowDefinition());
                var textBox = new TextBox();
                textBox.Name = "Team" + (i + 1).ToString();
                textBox.Text = "";
                textBox.Width = 180;
                textBox.Height = 20;
                textBox.HorizontalContentAlignment = HorizontalAlignment.Center;
                textBox.VerticalContentAlignment = VerticalAlignment.Center;
                ViewTeamsGrid.Children.Add(textBox);
                Grid.SetRow(textBox, ViewTeamsGrid.RowDefinitions.Count - 1);
                _textBoxes.Add(textBox);
            }
        }
    }
}
