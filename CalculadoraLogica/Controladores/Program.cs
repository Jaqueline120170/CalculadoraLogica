using CalculadoraLogica.Servicios;

namespace CalculadoraLogica.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                int opcion = mi.mostrarMenu();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("¡Hasta pronto!");
                        cerrarMenu = true;
                        break;

                    case 2:
                        Console.WriteLine("Ha elegido Igualdad");
                        Console.WriteLine("Introduce una palabra: ");
                        string palabra1 = Console.ReadLine();
                        Console.WriteLine("Introduce una palabra: ");
                        string palabra2 = Console.ReadLine();
                        if (palabra1 == palabra2)
                        {
                            Console.WriteLine("El resultado de la igualdad es: True");
                        }
                        else
                        {
                            Console.WriteLine("El resultado de la igualdad es: False");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ha elegido Desigualdad");
                        Console.WriteLine("Introduce una palabra: ");
                        palabra1 = Console.ReadLine();
                        Console.WriteLine("Introduce una palabra: ");
                        palabra2 = Console.ReadLine();
                        if (palabra1 != palabra2)
                        {
                            Console.WriteLine("El resultado de la desigualdad es: True");
                        }
                        else
                        {
                            Console.WriteLine("El resultado de la desigualdad es: False");
                        }
                        break;
                }
            }
        }
    }
}