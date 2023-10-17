using CalculadoraLogica.Servicios;
using System.ComponentModel.Design;

namespace CalculadoraLogica

    ///<summary>
    ///Clase que controla el flujo de la aplicacion
    ///17102023- jal
    /// </summary>

{
    class Program

        ///<summary>
        ///clase desde donde iniciaremos la aplicacion
        ///17102023- jal
        /// </summary>

    {
        internal static void Main(string[] args)
        {
            string expresion1="", expresion2="";
            MenuInterfaz mi = new MenuImplementacion();

            int opcionSeleccionada;

            bool cerrarMenu = false;

            mi.MensajeBienvenida();
            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.MostrarMenuYSeleccion();

                if (opcionSeleccionada!=0)
                {
                    expresion1 = mi.pedirExpresion();
                    expresion2 = mi.pedirExpresion();
                }
                
                                   

                    switch (opcionSeleccionada)
                    {
                        case 0:

                            Console.WriteLine("[INFO] se ejecutara la opcion 0");

                            cerrarMenu = true;
                            break;

                        case 1:

                            Console.WriteLine("[INFO] Se ejecutara la opcion Igualdad");
                            mi.Igualdad(expresion1, expresion2);
                            break;

                        case 2:

                            Console.WriteLine("[INFO] se ejecutara la opcion Desigualdad");
                            mi.Desigualdad(expresion1, expresion2);
                            break;

                        default:
                            Console.WriteLine("[INFO] opcion introducida no es valida, por favor introduzca una opcion valida");
                            break;
                    }
                
            }
        }
    }
}


