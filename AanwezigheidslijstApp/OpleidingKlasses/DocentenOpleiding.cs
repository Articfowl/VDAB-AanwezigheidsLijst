using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpleidingKlasses
{
    public class DocentenOpleiding
    {
        [ForeignKey("Docent")]
        public int DocentId { get; set; }
        public Docent Docent { get; set; }
        [ForeignKey("Opleidingsinformatie")]
        public int OpleidingId { get; set; }
        public Opleidingsinformatie Opleidingsinformatie { get; set; }
        public int Id { get; set; }

        public DocentenOpleiding()
        {
        }

        public DocentenOpleiding(int docentId, int opleidingId)
        {
            DocentId = docentId;
            OpleidingId = opleidingId;
        }
    }
}
