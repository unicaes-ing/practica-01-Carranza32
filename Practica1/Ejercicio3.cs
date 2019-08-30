using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Ejercicio3
    {
        public static void Ejer3()
        {
            decimal num1 = 0, num2 = 0;
            Console.WriteLine("Ingrese el primer numero decimal");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero decimal");
            num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(String.Format("Suma: {0:C1}", num1 + num2));

            Console.WriteLine(String.Format("Resta: {0:C1}", num1 - num2));

            Console.WriteLine(String.Format("Multiplicacion: {0:C1}", num1 * num2));

            Console.WriteLine(String.Format("Division: {0:C1}", num1 / num2));

            Console.ReadKey();
        }
    }
}
