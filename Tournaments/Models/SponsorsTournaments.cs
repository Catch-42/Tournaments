using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tournaments.Models
{
    public class SponsorsTournaments
    {
        public decimal Sum { get; set; }
        public int SponsorId { get; set; }
        public virtual Sponsor Sponsor { get; set; }
    }
}