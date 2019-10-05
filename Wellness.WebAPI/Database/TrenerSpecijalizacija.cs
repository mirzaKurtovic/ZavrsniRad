using System;
using System.Collections.Generic;

namespace Wellness.WebAPI.Database
{
    public partial class TrenerSpecijalizacija
    {
        public int Id { get; set; }
        public int TrenerId { get; set; }
        public int TipTreningaId { get; set; }

        public virtual TipTreninga TipTreninga { get; set; }
        public virtual Trener Trener { get; set; }
    }
}
