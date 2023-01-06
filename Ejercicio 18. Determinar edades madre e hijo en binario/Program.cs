// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");
//18.recibir el año de nacimiento del usuario y año de nacimiento de su madre,
//determinar ambas edades, convertir edades a binario, imprimir ambas.
Console.WriteLine("Programa para determinar la edad del usuario y su mamá, en binario");
//DE
int año = 0;//Año de nacimiento
int edad = 0;
int añoMama = 0;
int edadMama = 0;
string exit = "x";
//Proceso
Console.WriteLine("Captura tu año de nacimiento");
año = int.Parse(Console.ReadLine());
edad = (DateTime.Today.Year) - año;
Console.WriteLine($"Tu edad es {edad}");
Console.WriteLine("Captura el año de nacimiento de tu mamá");
añoMama = int.Parse(Console.ReadLine());
edadMama = (DateTime.Today.Year) - añoMama;
//Convertiremos la edad de cada uno en binario. 
long binario = 0;//Creamos una variable de binario que inicie en 0
const int DIVISOR = 2;//Como para ser binario se toma la base 2.
long digito = 0;
//Se tomará que la edad la dividiremos entre el modulo de divisor (2), y que la edad sea menor que 0, y la edad
//sea igual que la division, 
for (int i = edad % DIVISOR, j = 0; edad > 0; edad /= DIVISOR, i = edad % DIVISOR, j++)
{
    digito = i % DIVISOR;
    binario += digito * (long)Math.Pow(10, j);
}
for (int i = edad % DIVISOR, j = 0; edad > 0; edad /= DIVISOR, i = edad % DIVISOR, j++)
{
    digito = i % DIVISOR;
    binario += digito * (long)Math.Pow(10, j);
}
Console.WriteLine("Tu edad en binario es " + binario);
Console.WriteLine("La edad de tu madre es " + binario);
