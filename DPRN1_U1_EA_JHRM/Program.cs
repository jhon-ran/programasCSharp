using System;
/*Programa que emula la funcionalidad de un cajero automático. 
 El usuario ingresa un monto a retirar y el programa indica el número de billetes a entregar de cada denominación.*/

namespace DPRN1_U1_EA_JHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declaran las variables iniciales
            int retiro;
            int quinientos = 0;
            int doscientos = 0;
            int cien = 0;
            int cincuenta = 0;

            Console.Write("***********************************\n\n");
            Console.Write("Bienvenido al cajero automático\n");
            Console.Write("***********************************\n\n");

            Console.Write("Ingresa el monto a retirar:\n");
            retiro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cantidad a retirar en pesos: " + retiro);

            //Billetes de 5000
            if (retiro >= 500)
            {
                quinientos = (retiro / 500);
                retiro = retiro - (quinientos * 500);
            }
            //Billetes de 200
            if (retiro >= 200)
            {
                doscientos = (retiro / 200);
                retiro = retiro - (doscientos * 200);
            }
            //Billetes de 100
            if (retiro >= 100)
            {
                cien = (retiro / 100);
                retiro = retiro - (cien * 100);
            }
            //Billetes de 50
            if (retiro >= 50)
            {
                cincuenta = (retiro / 50);
                retiro = retiro - (cincuenta * 50);
            }

            // Imprimir resultados
            Console.Write("Número de billetes a entregar de:\n");
            Console.WriteLine("500 pesos: " + quinientos);
            Console.WriteLine("200 pesos: " + doscientos);
            Console.WriteLine("100 pesos: " + cien);
            Console.WriteLine("50 pesos: " + cincuenta);
        }
    }
}
