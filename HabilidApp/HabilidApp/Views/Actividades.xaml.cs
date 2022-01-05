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
    public partial class Actividades : ContentPage
    {
        public HabilidadesModel habilidad;
        public Actividades()
        {
            InitializeComponent();
           
        } 

        public Actividades(HabilidadesModel item)
        {
            InitializeComponent();
            habilidad = item;
            BindingContext = new HabilidadesViewModel(item);
            
        }

        private async void Editar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditarHabilidad(habilidad));
        }

        private async void Actividades_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActividadXhabilidad(habilidad.idHabilidad));
        }
    }
}