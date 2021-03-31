using System;
/*programa que se compone de dos módulos. El primero construye dos triángulos (uno de cabeza y el otro regular) en base a un número de pisos seleccionado por el usuario. 
 * El segundo realiza la facturación de una tarjeta de crédito de acuerdo al monto a pagar y los pagos que se quieren realizar.*/

namespace DPRN1_U3_A4_JHRM
{

    class Opciones
    {
        //Pisos del triángulo
        int pisos, i, mes;
        double saldoInicial, pagoMensual, interes;

        //Método para construir un triágulo
        public void construir()
        {
            Console.WriteLine("Ingresa un número para tu triángulo, debe ser mayor a 0:");
            pisos = Convert.ToInt32(Console.ReadLine());

            // Verifica que el número no es negativo
            if (pisos < 0)
            {
                Console.WriteLine("Ingresa un número mayor a 0:");
                pisos = Convert.ToInt32(Console.ReadLine());
            }
           
            //Construye el 1er triángulo
            Console.WriteLine("1er triángulo rectángulo:");
            i = 1;
            while (i <= pisos)
            {
                Console.WriteLine(new string('*', i));
                i++;
            }

            //Construye el 2ndo triángulo
            Console.WriteLine("2do triángulo rectángulo:");
            i = pisos;
            while (i <= pisos)
            {
                Console.WriteLine(new string('*', i));
                i--;
                //Rompe el flujo cuando i llegue a 0
                if (i == 0)
                {
                    break;
                }
            }
        }

        //Método para calcular la facturación de pagos de tarjeta
        public void facturar()
        {
            interes = 1.015;
            mes = 0;
            //Usuario ingresa el saldo a pagar y los meses
            Console.WriteLine("Ingrese el saldo a pagar:");
            saldoInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el pago mensual que desea realizar:");
            pagoMensual = Convert.ToDouble(Console.ReadLine());

            //
            while (saldoInicial > 0)
            {
                //Se calcula el saldo con intereses menos el pago mensual
                saldoInicial = (saldoInicial * interes) - pagoMensual;
                mes++;
                //El flujo se detiene cuando el saldo llega a 0
                if (saldoInicial < 0)
                {
                    saldoInicial = 0;
                }
                Console.WriteLine("Mes #" + mes);
                Console.WriteLine("Saldo restante después de pago mensual: " + saldoInicial);


            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int menu;

            // Cambiamos color a la consola y le damos un numbre a la ventana
            Console.Title = "Programa de banco y de construcción";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("Elija el progama que desea:");
            Console.WriteLine("1 para construir un triángulo");
            Console.WriteLine("2 para factura de tarjeta de crédito");
            //se captura la opción del usuario
            menu = Convert.ToInt32(Console.ReadLine());

            //Menu
            switch (menu)
            {
                //Se crean los objetos dependiendo de la opción
                //Llama al método desado
                case 1:
                    Opciones obj1 = new Opciones();
                    obj1.construir();
                    break;
                case 2:
                    Opciones obj2 = new Opciones();
                    obj2.facturar();
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        }
    }
}
