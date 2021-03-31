using System;
/*Programa que calcula cuánta pintura y el costo que necesita el pintor para pintar una habitación. Considerando lo
siguiente:
El número de galones será calculado a partir del área de cada figura que compone la
habitación y los metros que cubre el galón de pintura. (Solo se pintarán paredes no
techos).Los resultados deben redondearse a galones enteros*/

namespace DPRN1_U2_EA_JHRM
{
    class Pintura
    {
        //Propiedades de clase
        public double largo, precio, metros, ancho, altura, bas, alturaHabitación, area;

        //Método para calcular la pintura de un cuadrado que regresa un valor
        public double CalCuadrado()
        {
            Console.WriteLine("Ingrese el largo: ");
            largo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            double area = (largo * altura) * 4 ;
            Console.WriteLine("Area de una habitación cuadrada a pintar: " + area);
            calPintura(area);
            return area;
        }

        //Método para calcular la pintura de un rectángulo que regresa un valor
        public double CalRectangulo()
        {
            Console.WriteLine("Ingrese el largo: ");
            largo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());
            double area1 = (largo * altura) * 2;
            double area2 = (ancho * altura) * 2;
            double area = area1 + area2;
            Console.WriteLine("Area de una habitación rectangular a pintar: " + area);
            calPintura(area);
            return area;
        }

        //Método para calcular la pintura de un triángulo que regresa un valor
        public int CalTriangulo()
        {

            Console.WriteLine("Ingrese la base: ");
            bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la altura: ");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la altura de la habitación: ");
            alturaHabitación = Convert.ToInt32(Console.ReadLine());

            double lados = (bas * bas) + (altura * altura);
            double hipotenusa = Math.Sqrt(lados);
            double pared1 = altura* alturaHabitación;
            double pared2 = bas * alturaHabitación;
            double pared3 = hipotenusa * alturaHabitación;
            double areaFinal = Math.Ceiling(pared1 + pared2 + pared3);
            int area = Convert.ToInt32(areaFinal);
            Console.WriteLine("Area de una habitación triangular a pintar: " + area);
            calPintura(area);
            return area;
        }

        //Método que calcula el costo, precio y cantidad de pintura. No regresa valores
        public void calPintura (double area)
        {
            Console.WriteLine("Ingrese el precio de galón de pintura: ");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese número de mt2 que cubre el galón de pintura: ");
            metros = Convert.ToDouble(Console.ReadLine());
            double area2 = Convert.ToDouble(area);

            double metrosxGalon = area2 / metros;
            
            double metrosxGalonRedo = Math.Ceiling(metrosxGalon);
            Console.WriteLine("Galones de pintura necesarios: " + metrosxGalonRedo);

            double difPintura = metrosxGalonRedo - metrosxGalon;
            Console.WriteLine("Cantidad de pintura que sobra: " + difPintura);

            double costo = precio * metrosxGalonRedo;
            Console.WriteLine("El costo para pintar la habitación es: " + costo);

            double presupuesto = Math.Ceiling(costo * 1.3);
            Console.WriteLine("Con una ganancia del 30% el presupuesto para pintar la habitación es: " + presupuesto);

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            int menu;

            Console.WriteLine("Elija la forma de la habitación a pintar:");
            Console.WriteLine("1 para cuadrado");
            Console.WriteLine("2 para rectángulo");
            Console.WriteLine("3 para triángulo");

            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                //Se crean los objetos dependiendo de la opción
                case 1:
                    Pintura obj1 = new Pintura();
                    obj1.CalCuadrado();
                    break;
                case 2:
                    Pintura obj2 = new Pintura();
                    obj2.CalRectangulo();
                    break;
                case 3:
                    Pintura obj3 = new Pintura();
                    obj3.CalTriangulo();
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }

        }
    }
}
