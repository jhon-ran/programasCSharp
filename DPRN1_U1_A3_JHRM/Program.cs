/*programa que calcula las raíces reales*/

using System;

namespace DPRN1_U1_A3_JHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declaran las variables para los valores a, b y c
            int a, b, c;
            //Se declaran las variables que contrendrán las raíces reales
            double d, x1, x2;
            

            Console.Write("\n\n");
            Console.Write("Bienvenido a la calculadora de raíces reales:\n");
            Console.Write("\n\n");

            //Se ingresa por teclado los valores a, b y c y se convierten a Int32 para evitar valores núlos
            //y poder calcular las raices reales
            // Ejemplo de raíces diferentes: a=1, b=5, c=2 
            // Ejemplo de iguales: a=1, b=2, c=1
            Console.Write("Ingresa el valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el valor de b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el valor de c: ");
            c = Convert.ToInt32(Console.ReadLine());

            // Se calcula mediante la formula
            d = b * b - 4 * a * c;
            //Si el calculo es igual a 0, ambas raíces son iguales
            if (d == 0)
            {
                Console.Write("Ambas raíces son iguales.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("Primera raíz = {0}\n", x1);
                Console.Write("Segunda raíz = {0}\n", x2);
            }
            //Si el calculo es mayor a 0, las raíces son diferentes
            else if (d > 0)
            {
                Console.Write("Ambas raíces son reales y diferentes\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("Primera raíz = {0}\n", x1);
                Console.Write("Segunda raíz = {0}\n", x2);
            }
            //En caso contrario, no se trata de raíces reales
            else
                Console.Write("No hay raíces reales, son lineares;\n");


        }
    }
}
