using HabilidApp.Models;
using HabilidApp.ViewModel;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HabilidApp.Views.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpCreateActividad
    {
        public PopUpCreateActividad()
        {
            InitializeComponent();
            BindingContext = new ActividadesViewModel();
        }

        public PopUpCreateActividad(int idhabilidad)
        {
            InitializeComponent();
            BindingContext = new ActividadesViewModel(idhabilidad);
        }

        private async void salir_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}