using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class PristupDanima
    {
        public PristupDanima()
        {
            PaketPristupniDani = new HashSet<PaketPristupniDani>();
        }

        public int Id { get; set; }
        public string DanUSedmici { get; set; }

        public virtual ICollection<PaketPristupniDani> PaketPristupniDani { get; set; }
    }
}
