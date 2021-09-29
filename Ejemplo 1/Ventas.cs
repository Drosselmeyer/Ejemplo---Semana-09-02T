using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo_1
{
    public class Ventas
    {
        //Propiedaes
        public int IdVenta { set; get; }
        public int IdVendedor { set; get; }
        public double Cantidad { set; get; }

        //Constructor
        public Ventas()
        {
            this.IdVenta = 0;
            this.IdVendedor = 0;
            this.Cantidad = 0;
        }
    }
}