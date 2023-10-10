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
    }
}
