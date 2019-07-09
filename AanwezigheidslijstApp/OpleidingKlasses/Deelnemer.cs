using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpleidingKlasses
{
    public class Deelnemer
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Woonplaats { get; set; }
        public int BadgeNummer { get; set; }

        public Deelnemer()
        {
        }

        public Deelnemer(string naam, DateTime geboorteDatum, string woonplaats, int badgeNummer)
        {
            Naam = naam;
            GeboorteDatum = geboorteDatum;
            Woonplaats = woonplaats;
            BadgeNummer = badgeNummer;
        }
    }
}
