using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mobile.Models
{
    class PostavkeModel
    {
        private int _Id { get; set; }
        private string _Ime { get; set; }
        private string _Prezime { get; set; }
        private DateTime? _DatumRodenja { get; set; }
        private string _Spol { get; set; }
        private string _Jmbg { get; set; }
        private string _Email { get; set; }
        private string _BrojTelefona { get; set; }
        private string _KorisnickoIme { get; set; }



        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<System.ComponentModel.DataErrorsChangedEventArgs> ErrorsChanged;




        public int Id
        {

            get { return this._Id; }
            set
            {
                this._Id = value;
                RaisePropertyChanged("Id");
            }
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje obavezno")]
        [StringLength(maximumLength:32,MinimumLength =5,ErrorMessage ="Broj karaktera mora biti izmedju 5 i 32")]
        [RegularExpression(@"[A-Za-z]+", ErrorMessage = "Samo slova dozvoljena")]
        public string Ime
        {

            get { return this._Ime; }
            set
            {
                this._Ime = value;
                RaisePropertyChanged("Ime");
            }
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje obavezno")]
        [StringLength(maximumLength: 32, MinimumLength = 5, ErrorMessage = "Broj karaktera mora biti izmedju 5 i 32")]
        [RegularExpression(@"[A-Za-z]+", ErrorMessage = "Samo slova dozvoljena")]
        public string Prezime
        {

            get { return this._Prezime; }
            set
            {
                this._Prezime = value;
                RaisePropertyChanged("Prezime");
            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje obavezno")]
        public DateTime? DatumRodenja
        {

            get { return this._DatumRodenja; }
            set
            {
                this._DatumRodenja = value;
                RaisePropertyChanged("DatumRodenja");
            }
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje obavezno")]
       
        [RegularExpression(@"[A-Za-z]{1}", ErrorMessage = "Vrijednost mora biti M ili Z")]
        public string Spol
        {

            get { return this._Spol; }
            set
            {
                this._Spol = value;
                RaisePropertyChanged("Spol");
            }
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje obavezno")]
        [StringLength(maximumLength: 32, MinimumLength = 5, ErrorMessage = "Broj karaktera mora biti 13")]
        [RegularExpression(@"[0-9]{13}", ErrorMessage = "Samo brojevi dozvoljeni")]
        public string Jmbg
        {

            get { return this._Jmbg; }
            set
            {
                this._Jmbg = value;
                RaisePropertyChanged("Jmbg");
            }
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje obavezno")]
        [EmailAddress(ErrorMessage ="Email nije validan")]
        public string Email
        {

            get { return this._Email; }
            set
            {
                this._Email = value;
                RaisePropertyChanged("Email");
            }
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje obavezno")]

        [RegularExpression(@"[0-9]+", ErrorMessage = "Dozvoljeni samo brojevi")]
        public string BrojTelefona
        {

            get { return this._BrojTelefona; }
            set
            {
                this._BrojTelefona = value;
                RaisePropertyChanged("BrojTelefona");
            }
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje obavezno")]
        public string KorisnickoIme
        {

            get { return this._KorisnickoIme; }
            set
            {
                this._KorisnickoIme = value;
                RaisePropertyChanged("KorisnickoIme");
            }
        }



        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public IEnumerable GetErrors(string propertyName)
        {
            var list = new List<string>();
            //if (!propertyName.Equals("Title"))
            //    return list;

            //if (this.Title.Contains("Marketing"))
            //    list.Add("Marketing is not allowed");
            return list;
        }

    }
}
