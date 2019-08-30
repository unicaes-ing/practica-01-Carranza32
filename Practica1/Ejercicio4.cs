using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Ejercicio4
    {
        public static void Ejer4()
        {
            int num;
            Console.WriteLine("Ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("El numero no es positivo");
                return;
            }
            Console.WriteLine("Raiz cuadrada: {0}", Math.Sqrt(num));
            Console.ReadKey();
        }
    }
}
