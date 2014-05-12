using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COD2Paster.Models
{
    public class Player
    {
        public string Team { get; set; }
        public List<string> Name { get; set; }
        public string Playername { get {return (Name.Count > 0) ? Name.First() : "No Name";} }
        public List<TimeSpan> TimeJoin { get; set; }
        public int ID { get; set; }
        public double KD { get; set; }
        public int KillStreak { get; set; }
        public int TotalKills { get; set; }
        public int TotalDeads { get; set; }
        public int TotalSuicides { get; set; }

        public int Total { get; set; }

        public override string ToString()
        {
            return (Name.Count > 0) ? Name.First() : "No Name";
        }
    }
}
