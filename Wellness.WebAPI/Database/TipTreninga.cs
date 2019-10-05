using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class TipTreninga
    {
        public TipTreninga()
        {
            TrenerSpecijalizacija = new HashSet<TrenerSpecijalizacija>();
            Trening = new HashSet<Trening>();
        }

        public int Id { get; set; }
        public string TipTreninga1 { get; set; }
        public string Opis { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<TrenerSpecijalizacija> TrenerSpecijalizacija { get; set; }
        public virtual ICollection<Trening> Trening { get; set; }
    }
}
