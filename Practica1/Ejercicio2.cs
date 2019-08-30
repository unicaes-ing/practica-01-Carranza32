using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Ejercicio2
    {
        public static void Ejer2()
        {
            string nombre, cargo, correo;
            int edad;
            DateTime fecha;
            decimal sueldo;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su cargo:");
            cargo = Console.ReadLine();
            Console.WriteLine("Ingrese su correo:");
            correo = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su fecha de contratacion:");
            fecha = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese su sueldo:");
            sueldo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(String.Format("Nombre: {0}\nCargo: {1}\nCorreo: {2}\nEdad: {3}Fecha: {4}\nSueldo: {5:C2}", nombre, cargo, correo, edad, fecha, sueldo));

            Console.ReadKey();
        }
    }
}
