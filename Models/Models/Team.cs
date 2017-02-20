using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tournaments.Models;

namespace Tournaments.Models
{
    public class Team
    {       
        public Team()
        {
            this.Players = new HashSet<Player>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }

        public virtual ICollection<Player> Players { get; set; }

    }
}