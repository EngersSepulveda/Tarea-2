using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Colmado_itla
{

    class Ventas
    {
        public Clientes Cliente { get; set; }
        public List<Productos> Productos { get; set; }
        public double Monto
        {
            get

            {
                return Productos.Sum(item => item.Precio);

            }

            set

            {

                Monto = value;

            }
        }
    }
}
