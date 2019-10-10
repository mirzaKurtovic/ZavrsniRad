using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Models
{
    class ClanarinaModel
    {
        public int UplataZaMjesec { get; set; }
        public int UplataZaGodinu { get; set; }
        public DateTime DatumUplate { get; set; }
        public decimal IznosUplate { get; set; }
        public string Paket { get; set; }

        public string UplataMjesecGodina { get { return "Uplata za " + UplataZaMjesec.ToString() + ". mjesec " + UplataZaGodinu.ToString() + " godine"; } }
        public string PaketIznosUplate { get { return Paket + "  " + IznosUplate.ToString() + " KM"; } }
    }
}
