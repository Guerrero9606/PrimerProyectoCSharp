// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Programa que calcula el área de un rectángulo
int ladoA; //Declaración de variables
int ladoB;
int resultado;

Console.WriteLine("Calcula el área de un rectángulo!");
Console.WriteLine("Ingrese el valor del lado A: ");

ladoA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B: ");

ladoB = Convert.ToInt32(Console.ReadLine());

resultado = ladoA * ladoB;
Console.WriteLine("El resultado es " + resultado);
 