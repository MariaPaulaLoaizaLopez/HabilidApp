using HabilidApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HabilidApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarHabilidad : ContentPage
    {
        public AgregarHabilidad()
        {
            InitializeComponent();
            BindingContext = new HabilidadesViewModel();
        }

        private async void Calendar_Clicked(object sender, EventArgs e)
        {
            if (await Launcher.CanOpenAsync("https://calendar.google.com/calendar/"))
            {
                await Launcher.OpenAsync("https://calendar.google.com/calendar/");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("No se puede abrir el calendario", "No tiene instalada esta App", "Aceptar");
            }
        }
    }
}