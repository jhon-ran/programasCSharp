using System;
using System.Linq;
/*rograma que se compone de dos módulos. El primero permite clasificar fotografías si son blanco y negro o a color. 
 * El segundo calcula el número de niveles que tendrá una pirámide de acuerdo al número de cubos dado.*/

namespace DPRN1_U3_EA_JHRM
{

    class Opciones
    {
        //Variables para clasificar fotos
        int fila, columna, cubos;
        bool bn, color;
        string check;
        //Variables para construir pirámide
        int cubosPaso, nivel, i;

        public void clasificar()
        {
            string[,] matriz;
            Console.WriteLine("Este programa te ayuda a clasificar tus fotos si son blanco y negro o a color");
            Console.WriteLine("Introduce 1 número de filas:");
            fila = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce 1 número de columnas:");
            columna = Convert.ToInt32(Console.ReadLine());
            matriz = new string[fila, columna];

            Console.Write("Ingrese alguno de los siguientes colores: C = cian, M = magenta, Y = amarillo, W = blanco, G = gris, B = negro \n");
            //Se llena la matriz con entradas de usuario
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    Console.Write("Ingrese el color en la posicion [" + (f + 1) + "," + (c + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    //Convertir las entradas a mayusculas
                    string conversion = linea.ToUpper();
                    matriz[f, c] = conversion;
                }
            }

            Console.WriteLine("Colores ingresados\n");
            //Imprimir matriz
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }

            // Revisar que la foto contiene colores
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    //Se guardan los colores en una variable
                    check = matriz[f, c];

                    // Se comparan los colores
                    if (check.Contains('C'))
                    {
                        color = true;
                    }
                    else if (check.Contains('M'))
                    {
                        color = true;
                    }

                    else if (check.Contains('Y'))
                    {
                        color = true;
                    }
                    //Si solo contiene w, g, y b, la foto es blanco y negro
                    else if (check.Contains('W') && color == false)
                    {
                        bn = true;
                    }
                    else if (check.Contains('G') && color == false )
                    {
                        bn = true;
                    }
                    else if (check.Contains('B') && color == false)
                    {
                        bn = true;
                    }
                }
            }

            //Si blanco y negro == verdadero, la foto es blanco y negro
            if (bn == true)
            {
                Console.WriteLine("Blanco y negro");
            }
            else if (color == true)
            {
                Console.WriteLine("Color");
            }


        }

        public void construir()
        {
            Console.WriteLine("Este programa calcula la altura máxima de una pirámide:");
            Console.WriteLine("Ingrese el número de cubos para construir la pirámide:");
            //Usuario ingresa # de cubos
            cubos = Convert.ToInt32(Console.ReadLine());

            //Se inicializan las variables
            cubosPaso = 0;
            nivel = 0;

            // Iteración para calcular altura de pirámide
            for (i = 1; i < cubos; i++)
            {
                cubosPaso = cubosPaso + i;
                cubos = cubos - cubosPaso;
                nivel++;

            }
            Console.Write("La altura máxima de la pirámide es:" + nivel);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int menu;

            // Cambiamos color a la consola y le damos un numbre a la ventana
            Console.Title = "Programa de fotografías y de pirámide";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("Elija el progama que desea:");
            Console.WriteLine("1 para clasificar fotografías");
            Console.WriteLine("2 para construir pirámide");
            //se captura la opción del usuario
            menu = Convert.ToInt32(Console.ReadLine());

            //Menu
            switch (menu)
            {
                //Se crean los objetos dependiendo de la opción
                //Llama al método desado
                case 1:
                    Opciones obj1 = new Opciones();
                    obj1.clasificar();
                    break;
                case 2:
                    Opciones obj2 = new Opciones();
                    obj2.construir();
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        }
    }
}
