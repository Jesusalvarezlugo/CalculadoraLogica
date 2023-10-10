using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal interface MenuInterfaz
    {
        public void MensajeBienvenida();

        public int MostrarMenuYSeleccion();
    }
}
