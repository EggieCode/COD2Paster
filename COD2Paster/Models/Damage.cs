using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COD2Paster.Models
{
    public class Damage
    {
        public double Dam { get; set; }
        public string Weapon { get; set; }
        public string Bullet { get; set; }
        public bool Kill { get; set; }
        public string HitPlace { get; set; }

        public TimeSpan Time { get; set; }
        public Player Attacter { get; set; }
        public Player Victum { get; set; }
    }
}
