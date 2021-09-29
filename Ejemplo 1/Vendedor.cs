using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo_1
{
    public class Vendedor
    {
        //Propiedades
        public int IdVendedor { set; get; }
        public string Nombre { set; get; }
        public string Dui { set; get; }
        public double Sueldo { set; get; }

        //Constructor
        public Vendedor()
        {
            this.IdVendedor = 0;
            this.Nombre = "";
            this.Dui = "";
            this.Sueldo = 0;
        }
    }
}