using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpleidingKlasses
{
    public class OpleidingContext :DbContext
    {
        public DbSet<Deelnemer> Deelnemers { get; set; }
        public DbSet<DeelnemerOpleiding> DeelnemersOpleidingen { get; set; }
        public DbSet<Docent> Docenten { get; set; }
        public DbSet<DocentenOpleiding> DocentenOpleidingen { get; set; }
        public DbSet<NietOpleidingsDag> NietOpleidingsDagen { get; set; }
        public DbSet<Opleidingsinformatie> OpleidingsInformatie { get; set; }
        public DbSet<TijdRegistratie> Tijdsregistraties { get; set; }
        public OpleidingContext(): base("OpleidingTable") { }
    }
}
