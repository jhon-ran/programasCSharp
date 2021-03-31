# Programas en C#
9 programas en C# usando la plataforma .NET*

## DPRN1_U1_A3_JHRM
Programa de cálculo de raíces reales para una ecuación de segundo grado de la forma: ``ax2+bx+c=0``
### Entradas
Coeficientes de la ecuación (a, b y c)
### Salidas
El calculo de raíces

## DPRN1_U1_EA_JHRM
Programa de cajero automático
### Entradas
Cantidad a retirar (de tipo entero)
### Salidas
El número de billetes qu debe entregar de 500, 200, 100 y 50 pesos

## DPRN1_U2_A3_JHRM
Programa que simula el manejo de un garrafón de agua. 
### Propiedades
* capacidadMaxima (la cantidad máxima de agua puede contener el garrafón)
* cantidadActual (la cantidad actual de agua que hay en el garrafón)
* Constructor que establece la capacidad máxima en 20 (lt.) y la actualen cero (garrafón vacío)
* Constructor con la capacidad máxima del garrafón: inicializa la cantidad actual del garrafón igual a la capacidad máxima
* Constructor con la capacidad máxima y la cantidad actual. Si la cantidad actual es mayor que la capacidad máxima del garrafón, la ajustará al máximo
### Métodos
* ``llenarGarrafon`` el cual hace que la cantidad actual sea igual a la capacidad
* ``servirTaza``que simula la acción de servir una taza con la capacidad indicada. Si la cantidad actual de agua “no alcanza” para llenar la taza, se sirve lo que quede
* ``vaciarGarrafon`` que pone la cantidad actual en cero
* ``consultarGarrafon`` que muestra la cantidad actual de agua que tiene el garrafón

## DPRN1_U2_A4_JHRM
Programa que calcula la media, mediana, moda, número mayor y número menor a partir de 10 números ingresados.
### Entradas
10 Números enteros
### Salidas 
* Moda: devuelve el cálculo de la moda del conjunto de números
* Mediana: devuelve el cálculo de la media del conjunto de números
* Media: devuelve el cálculo del promedio del conjunto de números
* número menor: devuelve el menor número del conjunto de números
* número mayor: devuelve el menor número del conjunto de números

## DPRN1_U2_EA_JHRM
Programa que calcula cuánta pintura y el costo que necesita el pintor para pintar una habitación dependiendo sus dimensiones y forma
### Entradas
* Seleccionar la forma de la habitación que pintará (cuadrada, rectangular o triangular)
* Dimensiones: 
  * Cuadrado (Largo y altura de habitación)
  * Rectángulo (Largo, ancho y altura de la habitación)
  * Triángulo (Base, altura y altura de la habitación)
* Precio del galón de pintura 
* Número de metros cuadrados que cubre el galón
### Salidas
* Cuánta pintura y el costo que necesita el pintor para pintar la habitación
* Cuanta pintura sobrará después del redondeo
* Presupuesto considerando una ganancia del 30% para el pintor

## DPRN1_U3_A3_JHRM
Programa que calcula la suma, resta, multiplicación o división de 2 numeros
## Entradas
2 números
## Salidas
Resultado del cálculo

## DPRN1_U3_A4_JHRM
Programa que se compone de dos módulos. El primero construye dos triángulos (uno de cabeza y el otro regular) en base a un número de pisos seleccionado por el usuario. El segundo realiza la facturación de una tarjeta de crédito de acuerdo al monto a pagar y los pagos que se quieren realizar
### Entradas
* Número de de pisos para pirámide (int)
* Saldo inicial (int)
* Pago mensual (int)
### Salidas
* Pagos mensuales
* Número de pagos mensuales a realizar

## DPRN1_U3_EA_JHRM
Programa que se compone de dos módulos. El primero permite clasificar fotografías si son blanco y negro o a color. El segundo calcula el número de niveles que tendrá una pirámide de acuerdo al número de cubos dado
### Entradas
* Número de filas (int)
* Número de columnas
* Letras en función de colores (string)
* Número de cubos para pirámide (int)
### Salidas
* Color de foto
* Altura máxima de pirámide en función de los cubos (int)

## DPRN1_U3_AC_JHRM
Programa con un menú y 5 módulos: 
* 1. El usuario ingresa su apellido y se le asigna una mascota de acuerdo a la primera letra del mismo
* 2. Se pueden dar alta las mascotas en la tienda, actualizando la base de datos (simulada por ahora) 
* 3. Se pueden dar de baja las mascotas del inventario
* 4. Se puede vender una mascota al cliente
## Entradas
* Appellido paterno (string)
* Animal (string)
* Raza (string)
* Cantidad de animales (int)
* Selección de mascota a dar de baja (int)
* Cantidad a dar de baja (int)
* Seleccioonar mascota para ver (int)
* Salir (s/n) (string)
* Elejir mascota a vender (int)
* Denominación de billetes y monedas de 500, 200, 100, 50, 20, 5, 1 (int)

## Salidas
* Mascota (string)
* Denominación de billetes y monedas a entregar de 500, 200, 100, 50, 20, 5, 1 (int)
* Cambio
