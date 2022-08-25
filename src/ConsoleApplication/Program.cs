//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            for(int i=0; i<100;i++)
            {
                var Tren = new Train($"Thomas {i}");
            }

            Console.WriteLine($"Contador: {Train.Count}");
            
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");

            Console.WriteLine($"t1 == t2: {t1 == t2}");
            Console.WriteLine($"t2 == t3: {t1 == t2}");
            /* 
            7) Al crear 1000000 objetos de clase tren lo que sucede es que 
            se llena el heap de la memoria y el runetime comienza a eliminar
            los objetos de clase tren que no están siendo utilizados para
            asi poder asignar los nuevos objetos.

            9) Ninguno de los trenes son iguales entre si ya que todas las
            variables apuntan a distintos objetos de la misma clase.
            */
            
            
        }
    }
}