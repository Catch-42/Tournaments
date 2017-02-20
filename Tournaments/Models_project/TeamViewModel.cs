﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tournaments.Models;

namespace Tournaments.Models_project
{
    public class TeamPlayersViewModel
    {
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<Player> Players { get; set; }
    }
}