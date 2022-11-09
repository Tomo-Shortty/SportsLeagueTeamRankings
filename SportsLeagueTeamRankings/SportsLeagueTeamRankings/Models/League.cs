using SportsLeagueTeamRankings.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLeagueTeamRankings.Models
{
    public class League
    {
        public string Name { get; set; }
        public CompetitionType CompetitionType { get; set; }
        public int NumberOfTeams { get; set; }
        public int NumberOfDivisions { get; set; }
    }
}
