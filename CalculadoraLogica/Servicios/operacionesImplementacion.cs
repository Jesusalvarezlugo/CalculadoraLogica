using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal class operacionesImplementacion : operacionesInterfaz
    {
        public bool Desigualdad(string expresion1, string expresion2)
        {

            bool desigualdad = expresion1 != expresion2;

            Console.WriteLine("Resultado de la desigualdad: {0}", desigualdad);

            return desigualdad;



        }

        public bool Igualdad(string expresion1, string expresion2)
        {



            bool igualdad = expresion1 == expresion2;

            Console.WriteLine("Resultado de la igualdad: {0}", igualdad);
            return igualdad;
        }



        public string pedirExpresion()
        {
            string expresion;
            Console.WriteLine("\nIntroduzca una expresion: ");
            expresion = Console.ReadLine();

            return expresion;
        }
    }
}
