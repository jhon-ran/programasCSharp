using System;
/*programa que se compone de 5 módulos: 
 En la primera, el usuario ingresa su apellido y se le asigna una mascota de acuerdo a la primera letra del mismo. 
En la segunda, se pueden dar alta las mascotas en la tienda, actualizando la base de datos (simulada por ahora). 
En la tercera, se pueden dar de baja las mascotas del inventario. 
En la cuarta, se puede vender una mascota al cliente. */

namespace DPRN1_U3_AC_JHRM
{

    class Usuario
    {
        //Variables para apellido
          string apellido;      

        public void asignarMascota()
        {
            Console.WriteLine("Ingrese su apellido paterno:");
            apellido = Console.ReadLine();
            //Hacerlo en minúsculas
            apellido.ToLower();
            //Si el apellido paterno empieza por A, B, C, D, E
            if (apellido.StartsWith("a") || apellido.StartsWith("b") || apellido.StartsWith("c") || apellido.StartsWith("d") || apellido.StartsWith("e"))
            {
                Console.WriteLine("Serpiente");
            }
            //Si el apellido paterno empieza por F, G, H, I, J
            else if (apellido.StartsWith("f") || apellido.StartsWith("g") || apellido.StartsWith("h") || apellido.StartsWith("i") || apellido.StartsWith("j"))
            {
                Console.WriteLine("Perro");
            }
            //Si el apellido paterno empieza por K, L, M, N, ñ
            else if (apellido.StartsWith("k") || apellido.StartsWith("l") || apellido.StartsWith("m") || apellido.StartsWith("n") || apellido.StartsWith("ñ") || apellido.StartsWith("o"))
            {
                Console.WriteLine("Loro");
            }
            //Si el apellido paterno empieza por P, Q, R, S, T, U
            else if (apellido.StartsWith("p") || apellido.StartsWith("q") || apellido.StartsWith("r") || apellido.StartsWith("s") || apellido.StartsWith("t") || apellido.StartsWith("u"))
            {
                Console.WriteLine("Pez");
            }
            //Si el apellido paterno empieza por V, W, X, Y, Z
            else if (apellido.StartsWith("v") || apellido.StartsWith("w") || apellido.StartsWith("x") || apellido.StartsWith("y") || apellido.StartsWith("z"))
            {
                Console.WriteLine("Araña");
            }
            else
            {
                Console.WriteLine("Apellido no válido, debe empezar con una letra");
            }

        }

    }

    class Mascota
    {
        //Variables para mascotas
        string animal, razaPerro;
        int cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana, cantidad;
        int opcion;

        // Variables para administrar la caja
        int caja, costo, cambio, cambioFinal;
        //Billetes permitidos
        int veinte, cincuenta, cien, doscientos, quinientos, pago;
        //Monedas permitidas
        int uno, cinco, diez;

        //Método para agregar mascotas al inventario
        public void agregarMascota()
        {
            //Para simular una base de datos se inicializan los animales con un número
            cantidadSerpiente = 5;
            cantidadPerro = 15;
            cantidadLoro = 2;
            cantidadPez = 3;
            cantidadArana = 8;

            Console.WriteLine("Agregar una mascota al inventario\n");
            Console.WriteLine("Inventario actual:");
            Console.WriteLine("Hay {0} serpientes, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);

 
            Console.WriteLine("Opciones: serpiente, perro, loro, pez o araña\n");
            Console.WriteLine("Ingrese animal");
            animal = Console.ReadLine();
            animal.ToLower();

            if (animal == "perro")
            {
                Console.WriteLine("Ingrese raza:");
                razaPerro = Console.ReadLine();
                Console.WriteLine("Ingrese cantidad de perros:");
                cantidad = Convert.ToInt32(Console.ReadLine());
                cantidadPerro = cantidadPerro + cantidad;

                Console.WriteLine("Ingresó {0} perro(s) de raza {1}", cantidad, razaPerro);
                Console.WriteLine("Hay ahora {0} serpientes, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);

            }
            else if (animal == "serpiente")
            {
                Console.WriteLine("Ingrese cantidad serpientes:");
                cantidad = Convert.ToInt32(Console.ReadLine());
                cantidadSerpiente = cantidadSerpiente + cantidad;

                Console.WriteLine("Ingresó {0} serpiente(s)", cantidad);
                Console.WriteLine("Hay ahora {0} serpientes, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
            }
            else if (animal == "loro")
            {
                Console.WriteLine("Ingrese cantidad de loros:");
                cantidad = Convert.ToInt32(Console.ReadLine());
                cantidadLoro = cantidadLoro + cantidad;

                Console.WriteLine("Ingresó {0} loro(s)", cantidad);
                Console.WriteLine("Hay ahora {0} serpientes, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
            }
            else if (animal == "pez")
            {
                Console.WriteLine("Ingrese cantidad de peces:");
                cantidad = Convert.ToInt32(Console.ReadLine());
                cantidadPez = cantidadPez + cantidad;

                Console.WriteLine("Ingresó {0} peces(s)", cantidad);
                Console.WriteLine("Hay ahora {0} serpientes, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
            }
            else if (animal == "araña")
            {
                Console.WriteLine("Ingrese cantidad de arañas:");
                cantidad = Convert.ToInt32(Console.ReadLine());
                cantidadArana = cantidadArana + cantidad;

                Console.WriteLine("Ingresó {0} araña(s)", cantidad);
                Console.WriteLine("Hay ahora {0} serpientes, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
            }
            else
            {
                Console.WriteLine("Lo siento, esa mascota no está en el catálogo.");
            }
        }

        //Método para quitar mascotas del inventario
        public void quitarMascota()
        {
            //Para simular una base de datos se inicializan los animales con un número
            cantidadSerpiente = 5;
            cantidadPerro = 15;
            cantidadLoro = 2;
            cantidadPez = 3;
            cantidadArana = 8;

            Console.WriteLine("Quitar una mascota del inventario\n");
            Console.WriteLine("Inventario actual:");
            Console.WriteLine("Hay {0} serpiente, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);


            Console.WriteLine("Elija la mascota quiere quitar del inventario\n");
            Console.WriteLine("1 perro");
            Console.WriteLine("2 serpiente");
            Console.WriteLine("3 pez");
            Console.WriteLine("4 loro");
            Console.WriteLine("5 araña");

            opcion = Convert.ToInt32(Console.ReadLine());
            //Menu
            switch (opcion)
            {
                //Se crean los objetos dependiendo de la opción
                //Llama al método desado
                case 1:
                    Console.WriteLine("Ingrese cantidad de perros que quiere quitar del inventario:");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    cantidadPerro = cantidadPerro - cantidad;
                    Console.WriteLine("Dio de baja {0} perro(s)", cantidad);
                    Console.WriteLine("Hay ahora {0} serpiente, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
                    break;
                case 2:
                    Console.WriteLine("Ingrese cantidad serpientes:");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    cantidadSerpiente = cantidadSerpiente - cantidad;
                    Console.WriteLine("Dio de baja {0} serpiente(s)", cantidad);
                    Console.WriteLine("Hay ahora {0} serpiente, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
            break;
                case 3:
                    Console.WriteLine("Ingrese cantidad de peces:");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    cantidadPez = cantidadPez - cantidad;
                    Console.WriteLine("Dio de baja {0} peces(s)", cantidad);
                    Console.WriteLine("Hay ahora {0} serpiente, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
                    break;
                case 4:
                    Console.WriteLine("Ingrese cantidad de loros:");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    cantidadLoro = cantidadLoro - cantidad;
                    Console.WriteLine("Dio de baja {0} loro(s)", cantidad);
                    Console.WriteLine("Hay ahora {0} serpiente, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
                    break;
                case 5:
                    Console.WriteLine("Ingrese cantidad de arañas:");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    cantidadArana = cantidadArana - cantidad;
                    Console.WriteLine("Dio de baja {0} araña(s)", cantidad);
                    Console.WriteLine("Hay ahora {0} serpiente, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        }
        //Método para que el comprador vea las mascotas
        public void mostrarMascota()
        {
            // variable para detener el flujo
            string parar = "";

            Console.WriteLine("Elija la mascota que quiere ver el comprador\n");
            Console.WriteLine("1 perro");
            Console.WriteLine("2 serpiente");
            Console.WriteLine("3 loro");
            Console.WriteLine("4 pez");
            Console.WriteLine("5 araña");

            opcion = Convert.ToInt32(Console.ReadLine());
            //Menu
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ver perro \n:");
                    do
                    {
                        Console.WriteLine("wow wow wow wow");
                        Console.WriteLine("¿Quiere dejar de ver el perro? (s/n)?");
                        parar = Console.ReadLine();
                        parar.ToLower();
                    } while (parar != "s");
                    break;
                case 2:
                    Console.WriteLine("Ver serpiente \n:");
                    do
                    {
                        Console.WriteLine("zzz zzzz zzzz zzzz");
                        Console.WriteLine("¿Quiere dejar de ver la serpiente? (s/n)?");
                        parar = Console.ReadLine();
                        parar.ToLower();
                    } while (parar != "s");
                    break;
                case 3:
                    Console.WriteLine("Ver loro \n:");
                    do
                    {
                        Console.WriteLine("lorito lorito lorito rrrrrrrr");
                        Console.WriteLine("¿Quiere dejar de ver el loro? (s/n)?");
                        parar = Console.ReadLine();
                        parar.ToLower();
                    } while (parar != "s");
                    break;
                case 4:
                    Console.WriteLine("Ver pez \n:");
                    do
                    {
                        Console.WriteLine("glup glup glup glup");
                        Console.WriteLine("¿Quiere dejar de ver el pez? (s/n)?");
                        parar = Console.ReadLine();
                        parar.ToLower();
                    } while (parar != "s");
                    break;
                case 5:
                    Console.WriteLine("Ver araña \n:");
                    do
                    {
                        Console.WriteLine("trr trr trr trr trr");
                        Console.WriteLine("¿Quiere dejar de ver la araña? (s/n)?");
                        parar = Console.ReadLine();
                        parar.ToLower();
                    } while (parar != "s");
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        }
        //Método para cobrar a clientes
       public void cobrar()
        {
            Console.WriteLine("Módulo de ventas\n");
            Console.WriteLine("Elija la mascota a vender:");
            Console.WriteLine("1 perro");
            Console.WriteLine("2 serpiente");
            Console.WriteLine("3 loro");
            Console.WriteLine("4 pez");
            Console.WriteLine("5 araña");
            opcion = Convert.ToInt32(Console.ReadLine());
            //Menu
            switch (opcion)
            {
                case 1:
                    costo = 2000;
                    Console.WriteLine("Un perro cuesta:");
                    venta(costo);
                    break;
                case 2:
                    costo = 550;
                    Console.WriteLine("Una serpiente cuesta:");
                    venta(costo);
                    break;
                case 3:
                    costo = 810;
                    Console.WriteLine("Un loro cuesta:");
                    venta(costo);
                    break;
                case 4:
                    costo = 320;
                    Console.WriteLine("Un pez cuesta:");
                    venta(costo);
                    break;
                case 5:
                    costo = 255;
                    Console.WriteLine("Una araña cuesta:");
                    venta(costo);
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }

        }

        public void venta(int costo)
        {
            //Para simular una base de datos se inicializan los animales con un número
            cantidadSerpiente = 5;
            cantidadPerro = 15;
            cantidadLoro = 2;
            cantidadPez = 3;
            cantidadArana = 8;

            //Inicia con precio de mascota seleccionada
            Console.WriteLine(costo);

            Console.WriteLine("Ingrese cantidad inicial de fondos en caja por denominación\n");
            Console.WriteLine("Billetes de $500:");
            quinientos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Billetes de $200:");
            doscientos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Billetes de $100:");
            cien = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Billetes de $50:");
            cincuenta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Billetes de $20:");
            veinte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monedas de $20:");
            diez = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monedas de $5:");
            cinco = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monedas de $1:");
            uno = Convert.ToInt32(Console.ReadLine());

            //Para calcular la cantidad que hay en la caja
            caja = (quinientos * 500) + (doscientos *200) + (cien *100) + (cincuenta *50)  + (veinte * 20) + (diez * 10) + (cinco * 5) + uno ;

            Console.WriteLine("El cliente debe pagar ${0} por su mascota\n", costo);

            Console.WriteLine("Ingrese pago de cliente por denominación\n");
            Console.WriteLine("Billetes de $500:");
            quinientos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Billetes de $200:");
            doscientos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Billetes de $100:");
            cien = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Billetes de $50:");
            cincuenta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Billetes de $20:");
            veinte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monedas de $10:");
            diez = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monedas de $5:");
            cinco = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monedas de $1:");
            uno = Convert.ToInt32(Console.ReadLine());

            pago = (quinientos * 500) + (doscientos * 200) + (cien * 100) + (cincuenta * 50) + (veinte * 20) + (diez * 10) + (cinco * 5) + uno;

            Console.WriteLine("El cliente pagó ${0}", pago);
            //Vefificar que el pago es suficiente
            if (pago < costo)
            {
                Console.WriteLine("La cantidad pagada no es suficiente");
            }
            else
            {

                cambio = pago - costo;
                cambioFinal = cambio;
                Console.WriteLine("Cambio a entregar: ${0}", cambio);
                //Se iguala a 0 las variables
                quinientos = 0;
                doscientos = 0;
                cien = 0;
                cincuenta = 0;
                veinte = 0;
                diez = 0;
                cinco = 0;
                uno = 0;

                //Billetes de 5000
                if (cambio >= 500)
                {
                    quinientos = (cambio / 500);
                    cambio = cambio - (quinientos * 500);
                }
                //Billetes de 200
                if (cambio >= 200)
                {
                    doscientos = (cambio / 200);
                    cambio = cambio - (doscientos * 200);
                }
                //Billetes de 100
                if (cambio >= 100)
                {
                    cien = (cambio / 100);
                    cambio = cambio - (cien * 100);
                }
                //Billetes de 50
                if (cambio >= 50)
                {
                    cincuenta = (cambio / 50);
                    cambio = cambio - (cincuenta * 50);
                }

                //Billetes de 20
                if (cambio >= 20)
                {
                    veinte = (cambio / 20);
                    cambio = cambio - (veinte * 20);
                }

                //Monedas de 10
                if (cambio >= 10)
                {
                    diez = (cambio / 10);
                    cambio = cambio - (diez * 10);
                }

                //Monedas de 5
                if (cambio >= 5)
                {
                    cinco = (cambio / 5);
                    cambio = cambio - (cinco * 5);
                }

                //Monedas de 5
                if (cambio >= 1)
                {
                    uno = (cambio / 1);
                    cambio = cambio - (uno * 1);
                }

                Console.WriteLine("Inventario antes de compra:");
                Console.WriteLine("Hay {0} serpiente, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
                // Imprimir resultados de cambio
                Console.Write("Número de billetes a entregar de:\n");
                Console.WriteLine("500 pesos: " + quinientos);
                Console.WriteLine("200 pesos: " + doscientos);
                Console.WriteLine("100 pesos: " + cien);
                Console.WriteLine("50 pesos: " + cincuenta);
                Console.WriteLine("20 pesos: " + veinte);
                Console.Write("Número de monedas a entregar de:\n");
                Console.WriteLine("10 pesos: " + diez);
                Console.WriteLine("5 pesos: " + cinco);
                Console.WriteLine("1 peso: " + uno);
                Console.WriteLine("Cambio total entregado: " + cambioFinal);

                //Quitar mascota de inventario

                //Dependiendo el costo de la mascota, lo da de baja en el inventario
                switch (costo)
                {
                    case 2000:
                        cantidadPerro = cantidadPerro - 1;
                        Console.WriteLine("Dio de baja {0} perro(s)", cantidad);
                        Console.WriteLine("Hay ahora {0} serpiente, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
                        break;
                    case 550:
                        cantidadSerpiente = cantidadSerpiente - 1;
                        Console.WriteLine("Dio de baja {0} serpiente(s)", cantidad);
                        Console.WriteLine("Hay ahora {0} serpiente, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
                        break;
                    case 320:
                        cantidadPez = cantidadPez - 1;
                        Console.WriteLine("Dio de baja {0} peces(s)", cantidad);
                        Console.WriteLine("Hay ahora {0} serpiente, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
                        break;
                    case 810:
                        cantidadLoro = cantidadLoro - 1;
                        Console.WriteLine("Dio de baja {0} loro(s)", cantidad);
                        Console.WriteLine("Hay ahora {0} serpiente, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
                        break;
                    case 255:
                        cantidadArana = cantidadArana - 1;
                        Console.WriteLine("Dio de baja {0} araña(s)", cantidad);
                        Console.WriteLine("Hay ahora {0} serpiente, {1} perros, {2} loros, {3} peces y {4} arañas:", cantidadSerpiente, cantidadPerro, cantidadLoro, cantidadPez, cantidadArana);
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }

            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int menu;

            // Cambiamos color a la consola y le damos un numbre a la ventana
            Console.Title = "Programa de mascotas";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1 para saber cuál es tu mascota de acuerdo a su apellido");
            Console.WriteLine("2 dar de alta mascotas");
            Console.WriteLine("3 dar de baja mascotas");
            Console.WriteLine("4 mostrar mascota al comprador");
            Console.WriteLine("5 vender una mascota");
            //se captura la opción del usuario
            menu = Convert.ToInt32(Console.ReadLine());

            //Menu
            switch (menu)
            {
                //Se crean los objetos dependiendo de la opción
                //Llama al método desado
                case 1:
                    Usuario obj1 = new Usuario();
                    obj1.asignarMascota();
                    break;
                case 2:
                    Mascota obj2 = new Mascota();
                    obj2.agregarMascota();
                    break;
                case 3:
                    Mascota obj3 = new Mascota();
                    obj3.quitarMascota();
                    break;
                case 4:
                    Mascota obj4 = new Mascota();
                    obj4.mostrarMascota();
                    break;
                case 5:
                    Mascota obj5 = new Mascota();
                    obj5.cobrar();
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        }
    }
}

