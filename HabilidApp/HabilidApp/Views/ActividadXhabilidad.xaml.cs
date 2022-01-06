using HabilidApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HabilidApp.Views.PopUp;
using HabilidApp.Models;

namespace HabilidApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActividadXhabilidad : ContentPage
    {
        public int idHabilidad;

        public ActividadXhabilidad()
        {
            InitializeComponent();
           

        }
        public ActividadXhabilidad(int idhabilidad)
        {
            InitializeComponent();
            idHabilidad = idhabilidad;
            BindingContext = new ActividadesViewModel(idhabilidad);


        }

        private void ListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {   
            PopupNavigation.Instance.PushAsync(new PopUpUpdateActividad(e.SelectedItem as ActividadesModel, idHabilidad));
        }

        private void Nueva_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopUpCreateActividad(idHabilidad));
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Inicio(), true);
        }
    }
}