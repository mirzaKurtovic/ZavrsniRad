using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class TrenerSpecijalizacijaInsertRequest
    {
        public int TrenerId { get; set; }
        public int TipTreningaId { get; set; }
    }
}
