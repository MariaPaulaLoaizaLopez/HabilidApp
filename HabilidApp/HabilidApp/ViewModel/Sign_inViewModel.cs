using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using HabilidApp.Models;

namespace HabilidApp.ViewModel
{
    class Sign_inViewModel: BaseViewModel
    {
        #region Atributos

        public string Nombre;

        public string Correo;

        public string Clave;

        #endregion

        #region Propiedades

        public String NombreEntry
        {
            get
            {
                return this.Nombre;
            }
            set
            {
                SetValue(ref this.Nombre, value);
            }
        }

        public String CorreoEntry
        {
            get
            {
                return this.Correo;
            }
            set
            {
                SetValue(ref this.Correo, value);
            }
        }

        public String ClaveEntry
        {
            get
            {
                return this.Clave;
            }
            set
            {
                SetValue(ref this.Clave, value);
            }
        }

        #endregion

        #region Comandos

        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(RegisterMethod);
            }
            set { }
        }
        #endregion

        #region Metodos

        public async void RegisterMethod()
        {
            var user = new UserModel();

            user.Nombre = Nombre;

            user.Correo = Correo;

            user.Clave = Clave;

            await App.Db.SaveUserModel(user);

            await Application.Current.MainPage.DisplayAlert("Registro exitoso", "Se guardaron los datos", "Aceptar");

        }

        }
    #endregion
}
