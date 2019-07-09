using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace OpleidingKlasses
{
    public class NietOpleidingsDag
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public bool Voormiddag { get; set; }
        public bool Namiddag { get; set; }
        [ForeignKey("Opleidingsinformatie")]
        public int OpleidingId { get; set; }
        public Opleidingsinformatie Opleidingsinformatie { get; set; }
        public NietOpleidingsDag()
        {
        }

        public NietOpleidingsDag(DateTime datum, bool voormiddag, bool namiddag, int opleidingId)
        {
            Datum = datum;
            Voormiddag = voormiddag;
            Namiddag = namiddag;
            OpleidingId = opleidingId;
        }
    }
}
