// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Programa que calcula el area de un rectangulo
int ladoA;
int ladoB;
int resultado;

Console.WriteLine("Calcula el area de un rectangulo");
Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToInt32(Console.ReadLine());

resultado = ladoA * ladoB;
Console.WriteLine("El lado A es: " + ladoA + " El lado B es: " + ladoB + " El resultado es: " + resultado);