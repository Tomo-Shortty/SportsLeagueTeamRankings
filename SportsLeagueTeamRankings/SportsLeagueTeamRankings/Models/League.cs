using SportsLeagueTeamRankings.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLeagueTeamRankings.Models
{
    internal class League
    {
        public string Name { get; set; }
        public CompetitionType CompetitionType { get; set; }
        public List<Team>? Teams { get; set; }
        public List<Season>? Seasons { get; set; }
        public double PointsDifferenceDivision { get; set; }
        public int PlayOffRank { get; set; }
        public bool IncludeSecondaryPlayOffRank { get; set; }
        public int? SecondaryPlayOffRank { get; set; }
        public double ExcellentScore { get; set; }
        public double GoodScore { get; set; }
        public double AverageScore { get; set; }
        public double BadScore { get; set; }
        public double TerribleScore { get; set; }
    }
}
