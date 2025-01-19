using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Ejercicio 7. Crea un programa que calcule el factorial de un número obtenido por consola. 
             */

            // Inicializamos las variables: 'num' para el número ingresado y 'resultado' para almacenar el factorial
            int num = 0;
            int resultado = 1;

            // Solicita al usuario que ingrese un número para calcular su factorial
            Console.WriteLine("Escribe un número para conocer su factorial:");

            num = int.Parse(Console.ReadLine()); // Convierte el número ingresado como texto a entero

            // Calcula el factorial usando un bucle 'do-while'
            do
            {
                resultado = resultado * num; // Multiplica el resultado actual por el número actual
                num--; // Decrementa el número para continuar el cálculo
            }
            while (num > 1); // El bucle continúa mientras 'num' sea mayor que 1

            // Muestra el resultado del cálculo
            Console.WriteLine("El resultado es:" + resultado);

        }
    }
}
