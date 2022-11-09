using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLeagueTeamRankings.Models
{
    public class TeamStanding
    {
        public int Id { get; set; }
        public string? SeasonName { get; set; }
        public string? TeamName { get; set; }
        public int SeasonRank { get; set; }
        public double LeaguePoints { get; set; }
        public double PointsDifference { get; set; }
        public bool WonAPlayOff { get; set; }
        public bool MadePremliminaryFinal { get; set; }
        public bool MadeGrandFinal { get; set; }
        public bool WonPremiership { get; set; }
        public bool BackToBackPremiershipWinner { get; set; }
        public bool WonWoodenSpoon { get; set; }
    }
}
