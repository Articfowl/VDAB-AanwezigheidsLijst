using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace OpleidingKlasses
{
    public class DeelnemerOpleiding
    {
        [ForeignKey("Deelnemer")]
        public int DeelnemerId { get; set; }
        public Deelnemer Deelnemer { get; set; }
        [ForeignKey("Opleidingsinformatie")]
        public int OpleidingId { get; set; }
        public Opleidingsinformatie Opleidingsinformatie { get; set; }
        public int Id { get; set; }

        public DeelnemerOpleiding()
        {
        }

        public DeelnemerOpleiding(int deelnemerId, int opleidingId)
        {
            DeelnemerId = deelnemerId;
            OpleidingId = opleidingId;
        }
    }
}
