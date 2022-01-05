using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabilidApp.Models
{
   public class HabilidadesModel
    {
        [PrimaryKey, AutoIncrement]

        public int idHabilidad { get; set; }

        public string NombreHabilidad { get; set; }

       // public int HorasInvertidas { get; set; }

        public bool Terminado { get; set; }

        public bool Notificacion { get; set; }


    }
}
