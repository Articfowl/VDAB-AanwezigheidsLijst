using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpleidingKlasses
{
   public class Opleidingsinformatie
    {
        public int Id { get; set; }
        public string Opleidingsinstelling { get; set; }
        public string Opleiding { get; set; }
        public string Contactpersoon { get; set; }
        public string Opleidingsplaats { get; set; }
        public string ReferentieOpleidingsPlaats { get; set; }
        public int OeNummer { get; set; }
        public int Opleidingscode { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EindDatum { get; set; }

        public Opleidingsinformatie()
        {
        }

        public Opleidingsinformatie(string opleidingsinstelling, string opleiding, string contactpersoon, string opleidingsplaats,
            string referentieOpleidingsPlaats, int oeNummer, int opleidingscode, DateTime startDatum, DateTime eindDatum)
        {
            Opleidingsinstelling = opleidingsinstelling;
            Opleiding = opleiding;
            Contactpersoon = contactpersoon;
            Opleidingsplaats = opleidingsplaats;
            ReferentieOpleidingsPlaats = referentieOpleidingsPlaats;
            OeNummer = oeNummer;
            Opleidingscode = opleidingscode;
            StartDatum = startDatum;
            EindDatum = eindDatum;
        }
    }
}
