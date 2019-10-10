using Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostavkePage : ContentPage
    {
        Wellness.Model.Requests.ClanViewRequest _clan = null;
        PostavkeViewModel model = null;
        public PostavkePage(Wellness.Model.Requests.ClanViewRequest clan)
        {
            InitializeComponent();

            _clan = clan;

            BindingContext = model = new PostavkeViewModel(clan);

            //Id
            //dataForm.Items[0].IsVisible = false;


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var validated = dataForm.Validate();


            if (validated == true)
            {
                //model.SpasiCommand = new Command(async () => await model.Spasi());
                model.SpasiCommand.Execute(null);
            }
        }

        private void dataForm_AutoGeneratingDataFormItem(object sender, Syncfusion.XForms.DataForm.AutoGeneratingDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem.Name == "Id")
                    e.DataFormItem.IsVisible = false;

                if (e.DataFormItem.Name == "KorisnickoIme")
                {
                    e.DataFormItem.IsReadOnly = true;
                    e.DataFormItem.LabelText = "Korisnicko ime";
                }

                if (e.DataFormItem.Name == "BrojTelefona")
                {
                    e.DataFormItem.LabelText = "Broj telefona";
                }

                if (e.DataFormItem.Name == "DatumRodenja")
                {
                    e.DataFormItem.LabelText = "Datum rodenja";
                }
                if (e.DataFormItem.Name == "Jmbg")
                {
                    e.DataFormItem.LabelText = "JMBG";
                }
            }
        }
    }
}