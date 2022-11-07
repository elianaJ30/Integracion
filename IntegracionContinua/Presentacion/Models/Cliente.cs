using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentacion.Models
{
    public class Cliente
    {
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public Nullable<bool> estado { get; set; }
        public Nullable<decimal> saldo { get; set; }        
    }
}