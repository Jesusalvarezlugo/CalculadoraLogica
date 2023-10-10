using CalculadoraLogica.Servicios;


namespace CalculadoraLogica
{
    class Program
    {
        internal static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();

            int opcionSeleccionada;

            bool cerrarMenu = false;

            mi.MensajeBienvenida();
            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.MostrarMenuYSeleccion();

                switch (opcionSeleccionada)
                {
                    case 0:

                        Console.WriteLine("[INFO] se ejecutara la opcion 0");

                        cerrarMenu = true;
                        break;

                    case 1:

                        Console.WriteLine("[INFO] Se ejecutara la opcion 1");
                        break;

                    case 2:

                        Console.WriteLine("[INFO] se ejecutara la opcion 2");
                        break;

                    default:
                        Console.WriteLine("[INFO] opcion introducida no es valida, por favor introduzca una opcion valida");
                        break;
                }
            }
        }
    }
}


