using HabilidApp.Models;
using HabilidApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HabilidApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            BindingContext = new HabilidadesViewModel();
        }

        private async void Historial_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Historial());
        }

        private async void Perfil_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perfil());
        }

        private async void Detalles_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Actividades());
        }

        private async void Nueva_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgregarHabilidad());
        }

        private async void ListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new Actividades(e.SelectedItem as HabilidadesModel));
        }
    }
}