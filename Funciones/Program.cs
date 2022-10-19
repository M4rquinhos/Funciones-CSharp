//Ejmplo1: Funciones simples. Retorna un valor

string ObtenerNombre()
{
    return "Marco";
}

var miNombre = ObtenerNombre();
var miNombre2 = ObtenerNombre();

Console.WriteLine($"Nombre 1: {miNombre}");
Console.WriteLine($"Nombre 2: {miNombre2}");


//Ejemplo 2: Funcion que no retorna nada

void ImprimirFechaYHoraActual()
{
    var fechaYHora = DateTime.Now;
    var mensaje = $"Hoy es {fechaYHora.ToString("dd-MM-yyyy hh:mm:ss")}";
    Console.WriteLine(mensaje);
}

ImprimirFechaYHoraActual();


//Ejemplo 3: funciones con parametros

int Duplicar(int valor) 
{
    return valor * 2; 
}


var dobleDe5 = Duplicar(5);
Console.WriteLine(dobleDe5);


int Sumar(int valor1, int valor2) 
{
    return valor1 + valor2;
}

var ResultadoSuma = Sumar(5,7);
Console.WriteLine(ResultadoSuma);

//Ejemplo 4: Orden de los parametros
void RepetirEnConsola(string mensaje, int veces) 
{
    for (int i = 0; i < veces; i++)
    {
        Console.WriteLine(mensaje);
    }
}


//RepetirEnConsola(3, "Marco Carrillo"); //Error: Orden incorrecto de los parametros

RepetirEnConsola("Marco Carrillo", 3); //Lo ideal es respetar el orden original de los parametros

RepetirEnConsola(veces: 5, mensaje: "Miaw"); //Usar parametros nombrados para no tener problemas con el orden de los parametros


//Ejemplo 5: Imprimir Matrices 

void ImprimirMatriz(int[,] MatrizBidimensaional) 
{
    for (int fila = 0; fila < MatrizBidimensaional.GetLength(0); fila++)
    {
        for (int columna = 0; columna < MatrizBidimensaional.GetLength(1); columna++)
        {
            Console.Write(MatrizBidimensaional[fila, columna]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[,] matriz = new int[2,2];
matriz[0,0] = 1;
matriz[0,1] = 2;
matriz[1,0] = 3;
matriz[1,1] = 4;

ImprimirMatriz(matriz);


//Ejemplo 6: Funciones con parametros opcionales. Parametros opcionales simpre van despues de los parametros requeridos

void ImprimirConsola(string mensaje, bool enMayusculas = true) //parametro opcional, ya que esta inicializado en true 
{
    if (enMayusculas)
    {
        mensaje = mensaje.ToUpper();
    }
    Console.WriteLine(mensaje);
}

var nombre = "Marco";
ImprimirConsola(nombre);

//ejemplo usando una constante para inicializar un parametro opcional
const bool mayusculas = true;
void ImprimirConsola2(string mensaje, bool enMayusculas = mayusculas) 
{
    if (enMayusculas)
    {
        mensaje = mensaje.ToUpper();
    }
    Console.WriteLine(mensaje);
}

//Ejemplo usando default para inicializar un parametro opcional de una funcion

void ImprimirConsola3(string mensaje, bool enMayusculas = default) //valor por defecto = false
{
    if (enMayusculas)
    {
        mensaje = mensaje.ToUpper();
    }
    Console.WriteLine(mensaje);
}


//Ejemplo 7: Funcion con un numero indetermiando de parametros

double CalcularPromedio(int[] numeros) 
{
    var suma = 0.0;
    foreach (var numero in numeros)
    {
        suma += numero;
    }
    return suma / numeros.Length;
}

var promedio1 = CalcularPromedio(new int[] {1, 5, 7, 9, 10, 132 });
Console.WriteLine($"El promedio 1 es: {promedio1}");

//Otra manera de solucionar el problema anterior, pero esta vez utilizando params

double CalcularPromedio2(params int[] numeros) //El parametro que usara params debe de ser el ultimo en caso de que haya más de 1 parametro
{
    var suma = 0.0;
    foreach (var numero in numeros)
    {
        suma += numero;
    }
    return suma / numeros.Length;
}

var promedio2 = CalcularPromedio2(1,23,5345,654,67);
Console.WriteLine($"El promedio 2 es: {promedio2}");


//Ejemplo 8: Funciones con parametros de tipo referencia para que la(s) variable(s) cambie fuera de la funcion tambien

int cantidad = 5;

void Ducplicar(ref int n) 
{
    n *= 2;
    Console.WriteLine($"El valor dentro de la funcion es: {n}");
}

Console.WriteLine($"El valor fuera de la funcion es: {cantidad}");
Ducplicar(ref cantidad);
Console.WriteLine($"El valor fuera de la funcion es: {cantidad}");

//Ejemplo tipos de referencia 
var numeros = new int[] { 1, 2, 3};

void DuplicarArreglo(int[] numeros) 
{
    for (int i = 0; i < numeros.Length; i++)
    {
        numeros[i] *= 2;
    }
}

void ImprimirArreglo(int[] numeros) 
{
    foreach (var numero in numeros)
    {
        Console.Write($"{numero} ");
    }
}

Console.Write("Arrglo antes de ser duplicado: ");
ImprimirArreglo(numeros);

Console.WriteLine();

DuplicarArreglo(numeros);

Console.Write("Arreglo despues de aplicar la duplicacion: ");
ImprimirArreglo(numeros);


//En el caso de las strings(tipo de referencia) son inmutables; cuando se quieren cambiar, se crea solamente una copia y sobre esa copia se trabaja




//Ejemplo 9: Funciones con parametros out:

//out funcion como ref(mirar ejemplo anterior). A diferencia de ref que tiene que estar las variables inicializadas para poder usarse, con out no s necesario