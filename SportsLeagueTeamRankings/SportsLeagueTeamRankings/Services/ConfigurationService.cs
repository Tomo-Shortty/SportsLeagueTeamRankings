using SportsLeagueTeamRankings.Constants;
using SportsLeagueTeamRankings.Enums;
using SportsLeagueTeamRankings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SportsLeagueTeamRankings.Services
{
    public static class ConfigurationService
    {
        private static bool CheckLeagueSetup(string leagueName, CompetitionType competitionType, string numberOfTeams, List<string> teamNames, string? numberOfDivisions)
        {
            if (!leagueName.Equals(string.Empty))
            {
                if (CheckIntNumberInputs(numberOfTeams, ConfigurationItemStrings.NumberOfTeams))
                {
                    if (teamNames.Count > 0)
                    {
                        if (competitionType == CompetitionType.League || competitionType == CompetitionType.Conference || competitionType == CompetitionType.Division)
                        {
                            if (competitionType == CompetitionType.Division)
                            {
                                if (CheckIntNumberInputs(numberOfDivisions, ConfigurationItemStrings.NumberOfDivisions))
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                return true;
                            }
                        }
                        else
                        {
                            throw new Exception(ConfigurationItemStrings.CompetitionType + " is not League, Conference or Division.");
                        }
                    }
                    else
                    {
                        throw new Exception("No teams have been entered.");
                    }
                }
            }
            else
            {
                throw new Exception(ConfigurationItemStrings.LeagueName + ErrorMessages.EmptyInput);
            }

            return false;
        }

        private static bool CheckSeasonSetup(string numberOfSeasons, List<string> seasonNames)
        {
            if (CheckIntNumberInputs(numberOfSeasons, ConfigurationItemStrings.NumberOfSeasons))
            {
                if (seasonNames.Count > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("No seasons have been entered.");
                }
            }

            return false;
        }

        private static bool CheckSetup(string configurationName, string playOffWinPoints, string preliminaryFinalAppearancePoints, string grandFinalAppearancePoints, string premiershipWinPoints, string backToBackPremiershipWinPoints,
            string woodenSpoonPoints, string pointsDifferenceDivision, string playOffRank, bool? includeSecondaryPlayOffRank, string? secondaryPlayOffRank, string excellentScore, string goodScore, 
            string averageScore, string badScore, string terribleScore)
        {
            if (!configurationName.Equals(string.Empty))
            {
                if (CheckDoubleNumberInputs(playOffWinPoints, ConfigurationItemStrings.PlayOffWin))
                {
                    if (CheckDoubleNumberInputs(preliminaryFinalAppearancePoints, ConfigurationItemStrings.PreliminaryFinalAppearance))
                    {
                        if (CheckDoubleNumberInputs(grandFinalAppearancePoints, ConfigurationItemStrings.GrandFinalAppearance))
                        {
                            if (CheckDoubleNumberInputs(premiershipWinPoints, ConfigurationItemStrings.PremiershipWin))
                            {
                                if (CheckDoubleNumberInputs(backToBackPremiershipWinPoints, ConfigurationItemStrings.BackToBackPremiershipWin))
                                {
                                    if (CheckDoubleNumberInputs(woodenSpoonPoints, ConfigurationItemStrings.WoodenSpoon))
                                    {
                                        if (CheckDoubleNumberInputs(pointsDifferenceDivision, ConfigurationItemStrings.PointsDifferenceDivision))
                                        {
                                            if (CheckIntNumberInputs(playOffRank, ConfigurationItemStrings.PlayOffRank))
                                            {
                                                if (CheckDoubleNumberInputs(excellentScore, ConfigurationItemStrings.ExcellentScore))
                                                {
                                                    if (CheckDoubleNumberInputs(goodScore, ConfigurationItemStrings.GoodScore))
                                                    {
                                                        if (CheckDoubleNumberInputs(averageScore, ConfigurationItemStrings.AverageScore))
                                                        {
                                                            if (CheckDoubleNumberInputs(badScore, ConfigurationItemStrings.BadScore))
                                                            {
                                                                if (CheckDoubleNumberInputs(terribleScore, ConfigurationItemStrings.TerribleScore))
                                                                {
                                                                    if (includeSecondaryPlayOffRank == true)
                                                                    {
                                                                        if (CheckIntNumberInputs(secondaryPlayOffRank, ConfigurationItemStrings.SecondaryPlayOffRank))
                                                                        {
                                                                            return true;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        return true;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                throw new Exception(ConfigurationItemStrings.ConfigurationName + ErrorMessages.EmptyInput);
            }

            return false;
        }

        private static bool CheckIntNumberInputs(string input, string constant)
        {
            if (!input.Equals(string.Empty))
            {
                if (int.TryParse(input, out _))
                {
                    return true;
                }
                else
                {
                    throw new Exception(constant + ErrorMessages.NotANumber);
                }
            }
            else
            {
                throw new Exception(constant + ErrorMessages.EmptyInput);
            }
        }

        private static bool CheckDoubleNumberInputs(string input, string constant)
        {
            if (!input.Equals(string.Empty))
            {
                if (double.TryParse(input, out _))
                {
                    return true;
                }
                else
                {
                    throw new Exception(constant + ErrorMessages.NotANumber);
                }
            }
            else
            {
                throw new Exception(constant + ErrorMessages.EmptyInput);
            }
        }

        public static bool ProcessConfiguration(string leagueName, CompetitionType competitionType, string numberOfTeams, List<string> teamNames, string? numberOfDivisions, string numberOfSeasons, List<string> seasonNames, 
            string configurationName, string playOffWinPoints, string preliminaryFinalAppearancePoints, string grandFinalAppearancePoints, string premiershipWinPoints, string backToBackPremiershipWinPoints, 
            string woodenSpoonPoints, string pointsDifferenceDivision, string playOffRank, bool? includeSecondaryPlayOffRank, string? secondaryPlayOffRank, bool? takeAverageScoreForMissingYears, string excellentScore, 
            string goodScore, string averageScore, string badScore, string terribleScore)
        {
            try
            {
                var leagueSetupComplete = CheckLeagueSetup(leagueName, competitionType, numberOfTeams, teamNames, numberOfDivisions);

                if (leagueSetupComplete)
                {
                    var seasonSetupComplete = CheckSeasonSetup(numberOfSeasons, seasonNames);

                    if (seasonSetupComplete)
                    {
                        var setupComplete = CheckSetup(configurationName, playOffWinPoints, preliminaryFinalAppearancePoints, grandFinalAppearancePoints, premiershipWinPoints, backToBackPremiershipWinPoints,
                            woodenSpoonPoints, pointsDifferenceDivision, playOffRank, includeSecondaryPlayOffRank, secondaryPlayOffRank, excellentScore, goodScore, averageScore, badScore, terribleScore);

                        if (setupComplete)
                        {
                            var confirmedNumberOfDivisions = DetermineOptionalInt(numberOfDivisions);

                            MainWindow.Instance.League = CreateLeague(leagueName, competitionType, int.Parse(numberOfTeams), confirmedNumberOfDivisions);
                            MainWindow.Instance.Teams = CreateTeamList(teamNames, MainWindow.Instance.League);
                            MainWindow.Instance.Seasons = CreateSeasonList(seasonNames, MainWindow.Instance.League);

                            var confirmedSecondaryPlayOffRank = DetermineOptionalInt(secondaryPlayOffRank);

                            MainWindow.Instance.Configuration = CreateConfiguration(configurationName, double.Parse(playOffWinPoints), double.Parse(preliminaryFinalAppearancePoints), double.Parse(grandFinalAppearancePoints), 
                                double.Parse(premiershipWinPoints), double.Parse(backToBackPremiershipWinPoints), double.Parse(woodenSpoonPoints), double.Parse(pointsDifferenceDivision), int.Parse(playOffRank), 
                                includeSecondaryPlayOffRank, confirmedSecondaryPlayOffRank, takeAverageScoreForMissingYears, double.Parse(excellentScore), double.Parse(goodScore), double.Parse(averageScore), 
                                double.Parse(badScore), double.Parse(terribleScore));

                            var league = MainWindow.Instance.League;
                            var teams = MainWindow.Instance.Teams;
                            var seasons = MainWindow.Instance.Seasons;
                            var configuration = MainWindow.Instance.Configuration;

                            if (league.CompetitionType == CompetitionType.Division)
                            {
                                MainWindow.Instance.SeasonRankPoints = CreateSeasonRankPointsList(league.NumberOfDivisions, configuration.PlayOffRank, configuration.SecondaryPlayOffRank);
                            }
                            else if (league.CompetitionType == CompetitionType.Conference)
                            {
                                var conferenceSplit = teams.Count / 2;
                                MainWindow.Instance.SeasonRankPoints = CreateSeasonRankPointsList(conferenceSplit, configuration.PlayOffRank, configuration.SecondaryPlayOffRank);
                            }
                            else
                            {
                                MainWindow.Instance.SeasonRankPoints = CreateSeasonRankPointsList(teams.Count, configuration.PlayOffRank, configuration.SecondaryPlayOffRank);
                            }

                            MainWindow.Instance.LeagueLabel.Content = league.Name;
                            MainWindow.Instance.CompetitionTypeLabel.Content = league.CompetitionType.ToString();
                            MainWindow.Instance.ConfigurationLabel.Content = configuration.Name;
                            MainWindow.Instance.CreateTeamStandingsTable(teams.Count, teams);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(ErrorMessages.ConfigurationError + e);
                return false;
            }

            return false;
        }

        private static League CreateLeague(string name, CompetitionType competitionType, int numberOfTeams, int? numberOfDivisions)
        {
            var league = new League();
            league.Name = name;
            league.CompetitionType = competitionType;
            league.NumberOfTeams = numberOfTeams;
            return league;
        }

        private static Team CreateTeam(string name, League league)
        {
            var team = new Team();
            team.Name = name;
            team.League = league;
            team.Points = null;
            team.Rank = null;
            return team;
        }

        private static List<Team> CreateTeamList(List<string> teamNamelist, League league)
        {
            var teamlist = new List<Team>();

            foreach (var name in teamNamelist)
            {
                var team = CreateTeam(name, league);
                teamlist.Add(team);
            }

            return teamlist;
        }

        private static Season CreateSeason(string name, League league)
        {
            var season = new Season();
            season.Name = name;
            season.League = league;
            return season;
        }

        private static List<Season> CreateSeasonList(List<string> seasonNameList, League league)
        {
            var seasonList = new List<Season>();

            foreach (var name in seasonNameList)
            {
                var season = CreateSeason(name, league);
                seasonList.Add(season);
            }

            return seasonList;
        }

        private static Configuration CreateConfiguration(string name, double playOffWinPoints, double preliminaryFinalAppearancePoints, double grandFinalAppearancePoints, double premiershipPoints, 
            double backToBackPremiershipPoints, double woodenSpoonPoints, double pointsDifferenceDivision, int playOffRank, bool? includeSecondaryPlayOffRank, int? secondaryPlayOffRank, 
            bool? takeAverageScoreForMissingYears, double excellentScore, double goodScore, double averageScore, double badScore, double terribleScore)
        {
            var configuration = new Configuration();

            configuration.Name = name;
            configuration.PlayOffRank = playOffRank;
            configuration.PreliminaryFinalAppearancePoints = preliminaryFinalAppearancePoints;
            configuration.GrandFinalAppearancePoints = grandFinalAppearancePoints;
            configuration.PremiershipPoints = premiershipPoints;
            configuration.BackToBackPremiershipPoints = backToBackPremiershipPoints;
            configuration.WoodenSpoonPoints = woodenSpoonPoints;
            configuration.PointsDifferenceDivision = pointsDifferenceDivision;
            configuration.PlayOffRank = playOffRank;
            configuration.IncludeSecondaryPlayOffRank = includeSecondaryPlayOffRank;
            configuration.SecondaryPlayOffRank = secondaryPlayOffRank;
            configuration.TakeAverageScoreForMissingYears = takeAverageScoreForMissingYears;
            configuration.ExcellentScore = excellentScore;
            configuration.GoodScore = goodScore;
            configuration.AverageScore = averageScore;
            configuration.BadScore = badScore;
            configuration.TerribleScore = terribleScore;

            return configuration;
        }

        private static int DetermineOptionalInt(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                return int.Parse(input);
            }
            else
            {
                return 0;
            }
        }

        private static List<SeasonRankPoints> CreateSeasonRankPointsList(int count, int playOffRank, int? secondaryPlayOffRank)
        {
            var rankPointsList = new List<SeasonRankPoints>();
            var points = -1.0;
            var incrementor = 1.0;

            for (int i = count; i > 0; i--)
            {
                if (i <= playOffRank && i > secondaryPlayOffRank)
                {
                    points += 1.0 + incrementor;
                    var rankPoints = CreateSeasonRankPoints(i, points);
                    rankPointsList.Add(rankPoints);
                }
                else if (i <= secondaryPlayOffRank)
                {
                    incrementor += 1.0;
                    points += 1.0 + incrementor;
                    var rankPoints = CreateSeasonRankPoints(i, points);
                    rankPointsList.Add(rankPoints);
                }
                else
                {
                    points += 1.0;
                    var rankPoints = CreateSeasonRankPoints(i, points);
                    rankPointsList.Add(rankPoints);
                }
            }

            return rankPointsList;
        }

        private static SeasonRankPoints CreateSeasonRankPoints(int rank, double points)
        {
            var rankPoints = new SeasonRankPoints();
            rankPoints.Rank = rank;
            rankPoints.Points = points;
            return rankPoints;
        }

        public static CompetitionType ConvertSelectedCompetitionTypeToEnum(string input)
        {
            var result = new CompetitionType();

            if (Enum.TryParse<CompetitionType>(input, out result))
            {
                return result;
            }
            else
            {
                throw new Exception("Cannot find selected competition type.");
            }
        }
    }
}
