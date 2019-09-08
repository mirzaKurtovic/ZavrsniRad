using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model
{
    public class PaketPristupniDani
    {
            public int Id { get; set; }
            public int PaketId { get; set; }
            public int PristupniDaniId { get; set; }

            public virtual Paket Paket { get; set; }
            public virtual PristupDanima PristupniDani { get; set; }
        
    }
}
