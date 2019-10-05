using System;
using System.Collections.Generic;

namespace Wellness.Model
{
    public partial class Trener
    {

        public int Id { get; set; }
        public int RadnikId { get; set; }
        public string Specializacija { get; set; }

        public virtual Radnik Radnik { get; set; }

        public string Display  {
            get
            {
                if (Radnik != null)
                    if (Radnik.Osoba != null)
                        return Radnik.Osoba.Ime + " " + Radnik.Osoba.Prezime;

                    return Id.ToString();
                
            }
            set { } }
    }
}
