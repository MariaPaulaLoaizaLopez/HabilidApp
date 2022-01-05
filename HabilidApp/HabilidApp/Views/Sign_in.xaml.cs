using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabilidApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HabilidApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sign_in : ContentPage
    {
        public Sign_in()
        {
            InitializeComponent();
            BindingContext = new Sign_inViewModel();
        }

        private async void Inicio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}