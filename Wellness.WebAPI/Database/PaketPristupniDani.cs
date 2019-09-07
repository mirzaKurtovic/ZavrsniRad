using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class PaketPristupniDani
    {
        public int Id { get; set; }
        public int PaketId { get; set; }
        public int PristupniDaniId { get; set; }

        public virtual Paket Paket { get; set; }
        public virtual PristupDanima PristupniDani { get; set; }
    }
}
