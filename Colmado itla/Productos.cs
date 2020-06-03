using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace Colmado_itla
{
    class Productos
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public int Subtotal { get { return Precio * Cantidad; } }


    }

}
