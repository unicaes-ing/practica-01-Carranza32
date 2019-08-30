using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Ejercicio6
    {
        public static void Ejer6()
        {
            string nombre;
            double sueldo;
            
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(nombre + "Con sueldo de: " + sueldo);
            Console.WriteLine("Descuentos:");

            double isss = sueldo * 0.0725, afp = sueldo * 0.13, renta = sueldo * 0.13;

            Console.WriteLine("ISSS: {0}\nAFP: {1}\nRenta: {3}", isss, afp, renta);

            Console.WriteLine("Total a pagar: {0}", (sueldo-isss));
            Console.ReadKey();
        }
    }
}
