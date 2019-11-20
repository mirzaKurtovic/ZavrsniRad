using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class PaketSearchRequest
    {
        public int? Id { get; set; }
        public string NazivPaketa { get; set; }
        public decimal? CijenaVecaOd { get; set; }
        public decimal? CijenaManjaOd { get; set; }
        public bool? Aktivan { get; set; }

    }
}
