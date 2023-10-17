using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal interface operacionesInterfaz
    {
        public bool Igualdad(string expresion1, string expresion2);

        /// <summary>
        /// método para verificar la desigualdad de las expresiones
        /// </summary>
        /// <param name="expresion1"></param>
        /// <param name="expresion2"></param>
        /// <returns></returns>
        public bool Desigualdad(string expresion1, string expresion2);

        /// <summary>
        /// método que pide la expresion a verificar
        /// </summary>
        /// <returns></returns>
        public string pedirExpresion();
    }
}
