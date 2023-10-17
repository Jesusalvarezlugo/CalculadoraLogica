using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra mensaje de bienvenida a la calculadora
        /// </summary>
        public void MensajeBienvenida();

        /// <summary>
        /// Muestra el menuú y se pide la opcion a elegir
        /// </summary>
        /// <returns>opcion elegida</returns>
        public int MostrarMenuYSeleccion();

        /// <summary>
        /// Método para verificar la igualdad de las expresiones
        /// </summary>
        /// <param name="expresion1"></param>
        /// <param name="expresion2"></param>
        /// <returns></returns>

       
    }
}
