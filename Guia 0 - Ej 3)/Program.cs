using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_0___Ej_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su Apellido: ");
            string apellido = Console.ReadLine();

            Console.Writeline();
            Console.WriteLine($"Su nombre completo es {nombre} {apellido}");
            Console.WriteLine();
            Console.WriteLine($"Su nombre es {nombre} y su apellido {apellido}");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ingrese una cadena de caracteres: ");
            string cadena = Console.ReadLine();

            Console.WriteLine();

            if(string.IsNullOrEmpty(cadena))
            {
                Console.WriteLine("La cadena que ingreso esta vacia. Error.");

            }
            else
            {
                Console.WriteLine("Se ingresó la cadena correctamente");
            }

            Console.WriteLine();

            Console.Write("Ingrese una segunda cadena de caracteres: ");
            string cadena2 = Console.ReadLine();

            Console.WriteLine();

            if (string.IsNullOrWhiteSpace(cadena2))
            {
                Console.WriteLine("La cadena que ingreso esta vacia o completa de espacios vacios. Error.");

            }
            else
            {
                Console.WriteLine("Se ingresó la cadena correctamente");
            }

            Console.WriteLine();

            Console.Write("Ingrese una tercer cadena de caracteres: ");
            string cadena3 = Console.ReadLine();
            int longitud = cadena3.Length;

            Console.WriteLine();

            Console.WriteLine($"La longitud del texto ingresado es de {longitud}");

            Console.WriteLine();

            Console.Write("Ingrese una cuarta cadena de caracteres: ");
            string cadena4 = Console.ReadLine();

            Console.WriteLine();

            if (cadena4.Contains("a"))
            {
                Console.WriteLine("La cadena que ingreso contiene la letra a");


            }

            Console.WriteLine();

            Console.Write("Ingrese una quinta cadena de caracteres: ");
            string cadena5 = Console.ReadLine();
            Console.Write("Ingrese una sexta cadena de caracteres: ");
            string cadena6 = Console.ReadLine();

            Console.WriteLine();

            if (cadena5.Contains(cadena6))
            {
                Console.WriteLine($"La cadena {cadena5} contiene a la cadena {cadena6}");
            }

            Console.WriteLine();

            Console.Write("Ingrese una septima cadena de caracteres: ");
            string cadena7 = Console.ReadLine();
            int longitud2 = cadena6.Length;

            if (longitud2 <= 5)
            {
                Console.WriteLine();
            }
            else
            {
                string ultimos = cadena7.Substring(longitud2 - 2);
                //string primeros = cadena6.s()// //caracteres del principio//

                Console.WriteLine($"Los ultimos caracteres de la cadena ingresada son: {ultimos}");

            }

            Console.WriteLine();

            Console.Write("Ingrese una octava cadena de caracteres: ");
            string cadena8 = Console.ReadLine();
            string sinespacios = cadena8.Trim();

            Console.WriteLine();
            Console.WriteLine($"La cadena ingresada sin espacios intermedios es: {cadena8}");

            Console.ReadKey();
        }
    }
}
