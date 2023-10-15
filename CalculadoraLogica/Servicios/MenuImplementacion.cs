using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            Console.WriteLine("###########");
            Console.WriteLine("1. Cerrar");
            Console.WriteLine("2. Igualdad");
            Console.WriteLine("3. Desigualdad");
            Console.WriteLine("Selecciona una opción: ");
            int opcion = Console.ReadKey(true).KeyChar-('0');
            Console.WriteLine("La opción seleccionada es: " + opcion);

            return opcion;
        }
    }
}
