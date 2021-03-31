using System;
//Programa que calcula la suma, resta, multiplicación o división de 2 numeros
namespace DPRN1_U3_A3_JHRM
{

     class Calculo
    {
        //Numeros para calcular suma, resta y multiplicación
        int num1, num2, resultado;
        //Numeros para calcular división
        double n1, n2, r;
        // Cambio de color de consola

        //Método que calcula la suma
        public void suma()
        {
            Console.WriteLine("Ingrese el primer número:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = Int32.Parse(Console.ReadLine());
            resultado = num1 + num2;
            Console.WriteLine("La suma de {0} y de {1} es : ", num1, num2);
            Console.WriteLine(resultado);
        }

        //Método que calcula la resta
        public void resta()
        {
            Console.WriteLine("Ingrese el primer número:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = Int32.Parse(Console.ReadLine());
            resultado = num1 - num2;
            Console.WriteLine("La resta de {0} y de {1} es : ", num1, num2);
            Console.WriteLine(resultado);
        }

        //Método que calcula la multiplicación
        public void multiplicacion()
        {
            Console.WriteLine("Ingrese el primer número:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = Int32.Parse(Console.ReadLine());
            resultado = num1 * num2;
            Console.WriteLine("La multiplicación de {0} y de {1} es : ", num1, num2);
            Console.WriteLine(resultado);
        }

        //Método que calcula la división
        public void division()
        {
            Console.WriteLine("Ingrese el primer número:");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            n2 = Convert.ToDouble(Console.ReadLine());

            //Condición que verifica si el segundo número es 0 para evitar errores 
            if (n2 == 0)
            {
                Console.WriteLine("No se puede dividir ningún número entre 0");
            }
            else
            {
                r = n1 / n2;
                Console.WriteLine("La división de {0} y de {1} es : ", n1, n2);
                Console.WriteLine(r);
            }
        }




        static void Main(string[] args)
        {

            string menu;
            Console.WriteLine("Elija la operación que desea realizar:");
            Console.WriteLine("+ para suma");
            Console.WriteLine("- para resta");
            Console.WriteLine("* para multiplicación");
            Console.WriteLine("/ para división");

            menu = Console.ReadLine();

            //Menu
            switch (menu)
            {
                //Se crean los objetos dependiendo de la opción
                //Llama al método desado
                case "+":
                    Calculo obj1 = new Calculo();
                    obj1.suma();
                    break;
                case "-":
                    Calculo obj2 = new Calculo();
                    obj2.resta();
                    break;
                case "*":
                    Calculo obj3 = new Calculo();
                    obj3.multiplicacion();
                    break;
                case "/":
                    Calculo obj4 = new Calculo();
                    obj4.division();
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }

        }

    }

}
    
