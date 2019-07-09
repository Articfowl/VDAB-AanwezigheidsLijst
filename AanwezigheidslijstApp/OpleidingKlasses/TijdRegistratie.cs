using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpleidingKlasses
{
    public class TijdRegistratie
    {
        public int Id { get; set; }
        public DateTime TimeScanned { get; set; }
        [ForeignKey("Opleidingsinformatie")]
        public int OpleidingId { get; set; }
        public Opleidingsinformatie Opleidingsinformatie { get; set; }

        [ForeignKey("Deelnemer")]
        public int DeelnemerId { get; set; }
        public Deelnemer Deelnemer { get; set; }

        public TijdRegistratie()
        {
        }

        public TijdRegistratie(DateTime timeScanned, int opleidingId, int deelnemerId)
        {
            TimeScanned = timeScanned;
            OpleidingId = opleidingId;
            DeelnemerId = deelnemerId;
        }
    }
}
