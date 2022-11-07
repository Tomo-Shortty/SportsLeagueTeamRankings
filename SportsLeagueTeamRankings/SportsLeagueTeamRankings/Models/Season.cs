﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLeagueTeamRankings.Models
{
    internal class Season
    {
        public string? Name { get; set; }
        public string? TeamName { get; set; }
        public int Rank { get; set; }
        public double LeaguePoints { get; set; }
        public double PointsDifference { get; set; }
    }
}
