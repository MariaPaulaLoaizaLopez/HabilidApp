using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabilidApp.Models
{
   public class ActividadesModel
    {
        [PrimaryKey, AutoIncrement]
        public int idActividad { get; set; }

        public int idHabilidad { get; set; }

        public string NombreActividad { get; set; }

        public bool Terminada { get; set; }

        public int duracion { get; set; }
    }
}
