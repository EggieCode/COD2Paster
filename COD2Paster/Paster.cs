using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using COD2Paster.Models;

namespace COD2Paster
{
    public class Paster
    {
        List<Player> _players = new List<Player>()
        {
            new Player() {
                ID = -1,
                Name = new List<string>() {"world"}

            }
        };
        List<Damage> _damages = new List<Damage>();
        public void PasteFile(string[] lines)
        {
            foreach (string l in lines)
            {
                Match match = Regex.Match(l, @"(?:[0-9]?[0-9]?[0-9]:[0-9][0-9]?)",
                    RegexOptions.IgnoreCase);

                string[] Time = match.Groups[0].Value.Split(new string[] { ":" }, StringSplitOptions.None);
                double min = Convert.ToDouble(Time[0]);
                double sec = Convert.ToDouble(Time[1]);
                long ticks = Convert.ToInt64(((min * 60) + sec) * 10000000);
                TimeSpan TimeDT = new TimeSpan(ticks);


                string newL = l.Replace(match.Groups[0].Value, "").Replace(" ", "");
                List<string> groups = new List<string>(newL.Split(new string[] { ";" }, StringSplitOptions.None));

                switch (groups.First())
                {
                    case "J":
                        ParsePlayer(TimeDT, groups);
                        break;
                    case "K":
                        Damage dmgK = ParseDamage(TimeDT, groups);
                        dmgK.Kill = true;
                        _damages.Add(dmgK);
                        break;
                    case "D":
                        Damage dmgD = ParseDamage(TimeDT, groups);
                        _damages.Add(dmgD);
                        break;
                }
            }

            _players = _players.Select(y =>
            {
                y.TotalSuicides = _damages
                        .Where(x => x.Victum.ID == x.Attacter.ID && x.Attacter.ID == y.ID)
                        .Count(x => x.Kill == true);
                y.TotalKills = Damages.Where(x => x.Kill == true && x.Attacter.ID == y.ID).Count();
                y.TotalDeads = Damages.Where(x => x.Kill == true && x.Victum.ID == y.ID).Count();
                y.KD = y.TotalKills / (y.TotalDeads == 0 ? 1 : y.TotalDeads);

                return y;
            }).ToList();
        }
        private void ParsePlayer(TimeSpan Time, List<string> groups)
        {
            int playerID = Convert.ToInt32(groups[2]);

            if (!_players.Exists(x => x.ID == playerID))
            {
                _players.Add(new Player()
                {
                    Name = new List<string>(){
                        groups[3]
                    },
                    ID = playerID,
                    TimeJoin = new List<TimeSpan>()
                    {
                        Time
                    }
                });
            }
            else
            {
                _players.Find(x => x.ID == playerID).TimeJoin.Add(Time);
                if (!_players.Where(x => x.ID == playerID).SelectMany(x => x.Name).Contains(groups[3]))
                {
                    _players.Find(x => x.ID == playerID).Name.Add(groups[3]);
                }
            }
        }

        private Damage ParseDamage(TimeSpan Time, List<string> groups)
        {
            return new Damage()
            {
                Kill = false,
                Bullet = groups[11],
                Dam = Convert.ToDouble(groups[10]),
                HitPlace = groups[12],
                Time = Time,
                Weapon = groups[9],
                Attacter = _players.Find(x => x.ID == Convert.ToInt32(groups[6])),
                Victum = _players.Find(x => x.ID == Convert.ToInt32(groups[2]))
            };
        }

        public List<Player> Players { get { return _players; } set { _players = value; } }
        public List<Damage> Damages { get { return _damages; } set { _damages = value; } }
    }
}
