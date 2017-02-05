using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tournaments.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal Prize { get; set; }        

    }
}