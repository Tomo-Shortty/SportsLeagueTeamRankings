using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLeagueTeamRankings.Models
{
    public class Team
    {
        public string Name { get; set; }
        public League League { get; set; }
        public double? Points { get; set; }
        public int? Rank { get; set; }
    }
}
