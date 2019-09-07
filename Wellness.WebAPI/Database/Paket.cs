using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class Paket
    {
        public Paket()
        {
            Clanarina = new HashSet<Clanarina>();
            PaketPristupniDani = new HashSet<PaketPristupniDani>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public decimal? Cijena { get; set; }
        public string Opis { get; set; }
        public bool? PristupGrupnimTreninzima { get; set; }
        public bool? NeogranicenPristup { get; set; }
        public DateTime? VrijemePristupaOd { get; set; }
        public DateTime? VrijemePristupaDo { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<Clanarina> Clanarina { get; set; }
        public virtual ICollection<PaketPristupniDani> PaketPristupniDani { get; set; }
    }
}
