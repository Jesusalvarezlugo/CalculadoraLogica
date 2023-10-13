using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        

        public void MensajeBienvenida()
        {
            string mensaje = "Bienvenido a la calculadora lógica";

            Console.WriteLine(mensaje);
        }

        public int MostrarMenuYSeleccion()
        {
            int opcion=9;
            Console.WriteLine("\t\t\t╔══════════════════════════════╗");
            Console.WriteLine("\t\t\t║             MENU             ║");
            Console.WriteLine("\t\t\t╠══════════════════════════════╣");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║      1.- Igualdad            ║");
            Console.WriteLine("\t\t\t║      2.- Desigualdad         ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║          0) Salir            ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t╚══════════════════════════════╝");
            Console.Write("\t\tIntroduce una opción: ");

            opcion = Console.ReadKey(true).KeyChar-('0');

            return opcion;
        }

        public bool Desigualdad(string expresion1, string expresion2)
        {

            bool desigualdad = expresion1 != expresion2;

            Console.WriteLine("Resultado de la desigualdad: {0}",desigualdad);

            return desigualdad;
           


        }

        public bool Igualdad(string expresion1, string expresion2)
        {

            

            bool igualdad=expresion1==expresion2;

            Console.WriteLine("Resultado de la igualdad: {0}",igualdad);
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
