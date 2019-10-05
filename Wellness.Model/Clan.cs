using System;
using System.Collections.Generic;

namespace Wellness.Model
{
    public partial class Clan
    {

        public int Id { get; set; }
        public bool? Aktivan { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public int OsobaId { get; set; }
        public byte[] Qrcode { get; set; }
        public string QrCodeText { get; set; }

        public virtual Osoba Osoba { get; set; }

    }
}
