using System;
//Se necesita este paquete para las funciones Max() y Min()
using System.Linq;
/*Porgrama que calcula la media, mediana y moda de una serie de números*/

namespace DPRN1_U2_A4_JHRM
{

    class Estadistica
    {
        //Arregelo para guardar los 10 números ingresados
        public int[] arreglo = new int[10];

        //Método para el ingreso de 10 números
        public int[] Leer()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingresa el número para el elemento {0}: ", i);
                arreglo[i] = Convert.ToInt32(Console.ReadLine());      
            }

            return arreglo;
        }

        //Método para mostrar los números ingresados
        public void Mostrar()
        {

            System.Console.WriteLine("Números ingresados:");
            for (int i = 0; i < 10; i++)
            {
                 System.Console.WriteLine(arreglo[i]);

            }

        }

        //Método que devuelve el cálculo de la moda del conjunto de números
        public int Moda()
        {
            var groupos = arreglo.GroupBy(v => v);
            int conteoMax = groupos.Max(g => g.Count());
            int moda = groupos.First(g => g.Count() == conteoMax).Key;
            System.Console.WriteLine("La moda es: " + moda);
            return moda;
        }

        //Método que devuelve el cálculo de la mediana del conjunto de números
        public int Mediana()
        {

            var media = 0.0;
            var arregloTamagno = arreglo.Length;
            
            Array.Sort(arreglo);
            if (arregloTamagno % 2 == 0)
            {
                var primerValor = arreglo[(arreglo.Length / 2) - 1];
                var segundoValor = arreglo[(arreglo.Length / 2)];
                media = (primerValor + segundoValor) / 2.0;
            }
            if (arregloTamagno % 2 == 1)
            {
                media = arreglo[(arreglo.Length / 2)];
            }
            System.Console.WriteLine("La mediana es: " + media);
            return 0;

            
  
        }

        //Método que devuelve el cálculo del promedio del conjunto de números
        public int Media()
        {

            System.Console.WriteLine("La media es: " + arreglo.Average());
            return 0;
        }

        //Método que devuelve el mayor número del conjunto de números
        public int Mayor()
        {
            int max = arreglo.Max();
            System.Console.WriteLine("El número mayor ingresado es: " + max);
            return max;
        }

        //Método que devuelve el menor número del conjunto de números
        public int Menor()
        {
            int min = arreglo.Min();
            System.Console.WriteLine("El número menor ingresado es: " + min);
            return min;
        }



    }


    class Program
    {
        static void Main(string[] args)
        {
            Estadistica obj1 = new Estadistica();
            obj1.Leer();
            obj1.Mostrar();
            obj1.Mayor();
            obj1.Menor();
            obj1.Moda();
            obj1.Mediana();
            obj1.Media();
            Console.ReadKey();
        }
    }
}
