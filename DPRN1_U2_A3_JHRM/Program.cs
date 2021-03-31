using System;
/*Programa que simula un garrafón de agua*/

namespace DPRN1_U2_A3_JHRM
{
    class GarrafonDeAgua
    {
        //Declaracón de propiedades de clase
        int capacidadMaxima;
        int cantidadActual;

        //Constructor predeterminado
        public GarrafonDeAgua()
        {
            cantidadActual = 0;
            capacidadMaxima = 20;
            
         }

        //Constructor capacidad máxima de garrafón
        public GarrafonDeAgua(int actual)
        {
            cantidadActual = 20;
        }

        //Constructor con la capacidad máxima y la cantidad actual
        public GarrafonDeAgua(int actual, int maxima)
        {
            if (actual > maxima)
            {
               cantidadActual = maxima;
            }
        }

        //Método para llenar garrafón
        public void llenarGarrafon()
        {
            cantidadActual = 20;
        }

        //Método para servir taza
        public void servirTaza(int taza)
        {
    
            if (cantidadActual < taza)
            {
                cantidadActual = taza - cantidadActual;
            }
            else
                cantidadActual -=  taza;

        }

        //Método para vaciar garrafón
        public void vaciarGarrafon()
        {
            cantidadActual = 0;
        }

        //Método para consultar garrafón
        public void consultarGarrafon()
        {
            Console.WriteLine("Cantidad actual de garrafón: " + cantidadActual);
            Console.WriteLine("Capacidad máxima de garrafón: " + capacidadMaxima);
        }

        static void Main(string[] args)
        {
            //Se crea el objeto 1 y se llama cada uno de los métodos
            GarrafonDeAgua obj1 = new GarrafonDeAgua();
            Console.WriteLine("**************Objeto 1***************");
            obj1.consultarGarrafon();
            obj1.llenarGarrafon();
            Console.WriteLine("Después de llenar garrafón ");
            obj1.consultarGarrafon();
            obj1.vaciarGarrafon();
            Console.WriteLine("Después de vaciar garrafón ");
            obj1.consultarGarrafon();
            obj1.servirTaza(2);
            Console.WriteLine("Después de servir taza ");
            obj1.consultarGarrafon();


            //Se crea el objeto 2 y se llama cada uno de los métodos
            GarrafonDeAgua obj2 = new GarrafonDeAgua(10);
            Console.WriteLine("**************Objeto 2***************");
            obj2.consultarGarrafon();
            obj2.llenarGarrafon();
            Console.WriteLine("Después de llenar garrafón ");
            obj2.consultarGarrafon();
            obj2.vaciarGarrafon();
            Console.WriteLine("Después de vaciar garrafón ");
            obj2.consultarGarrafon();
            obj2.servirTaza(6);
            Console.WriteLine("Después de servir taza ");
            obj2.consultarGarrafon();
      

            //Se crea el objeto 3 y se llama cada uno de los métodos
            GarrafonDeAgua obj3 = new GarrafonDeAgua(30, 20);
            Console.WriteLine("**************Objeto 2***************");
            obj3.consultarGarrafon();
            obj3.llenarGarrafon();
            Console.WriteLine("Después de llenar garrafón ");
            obj3.consultarGarrafon();
            obj3.vaciarGarrafon();
            Console.WriteLine("Después de vaciar garrafón ");
            obj3.consultarGarrafon();
            obj3.servirTaza(1);
            Console.WriteLine("Después de servir taza ");
            obj3.consultarGarrafon();
            Console.WriteLine("***************************************");


        }
    }
}
