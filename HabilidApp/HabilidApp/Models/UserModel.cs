using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace HabilidApp.Models
{
    public class UserModel
    {
        [PrimaryKey,AutoIncrement]
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Clave { get; set; }
    }
}
