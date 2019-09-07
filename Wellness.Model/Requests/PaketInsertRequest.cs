using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class PaketInsertRequest
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public decimal? Cijena { get; set; }
        public string Opis { get; set; }
        public bool? PristupGrupnimTreninzima { get; set; }
        public bool? NeogranicenPristup { get; set; }
        public DateTime? VrijemePristupaOd { get; set; }
        public DateTime? VrijemePristupaDo { get; set; }
        public byte[] Slika { get; set; }
    }
}
