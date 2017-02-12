using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tournaments.Models;

namespace Tournaments.Views
{
    public class PlayerArgs_ : EventArgs
    {
        public PlayerArgs_(Player player)
        {
            this.Player = player;
        }

        public Player Player{get;private set;}
    }
}