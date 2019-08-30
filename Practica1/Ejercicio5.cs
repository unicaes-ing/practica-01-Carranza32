using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Ejercicio5
    {
        public static void Ejer5()
        {
            decimal cant1=0;

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Ingrese la cantidad del trimestre {0}", i);
                cant1 += Convert.ToDecimal(Console.ReadLine());
            }
            Console.WriteLine("Promedio: {0}", cant1/4);
            Console.ReadKey();
        }
    }
}
