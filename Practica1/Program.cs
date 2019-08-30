using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int opc = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el ejercicio que desea ver");
                    Console.WriteLine("1 - Ejercicio 1");
                    Console.WriteLine("2 - Ejercicio 2");
                    Console.WriteLine("3 - Ejercicio 3");
                    Console.WriteLine("4 - Ejercicio 4");
                    Console.WriteLine("5 - Ejercicio 5");
                    Console.WriteLine("6 - Ejercicio 6");
                    Console.WriteLine("0 - Salir");

                    opc = Convert.ToInt32(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Ejercicio1.Ejer1();
                            break;
                        case 2:
                            Console.Clear();
                            Ejercicio2.Ejer2();
                            break;
                        case 3:
                            Console.Clear();
                            Ejercicio3.Ejer3();
                            break;
                        case 4:
                            Console.Clear();
                            Ejercicio4.Ejer4();
                            break;
                        case 5:
                            Console.Clear();
                            Ejercicio5.Ejer5();
                            break;
                        case 6:
                            Console.Clear();
                            Ejercicio6.Ejer6();
                            break;
                    }
                } while (opc != 0);
            }
            catch
            {

            }
        }
    }
}
