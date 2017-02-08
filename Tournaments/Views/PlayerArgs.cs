using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tournaments.Models;

namespace Tournaments.Views
{
    public class PlayerArgs : EventArgs
    {
        public PlayerArgs(Player player)
        {
            this.Player = player;
        }

        public Player Player{get;private set;}
    }
}