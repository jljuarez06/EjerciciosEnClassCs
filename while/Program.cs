// keer un numero entero y entrar el cuadrado de sus antecesores

using System;

int numero;

while   (true)
{
    Console.WriteLine("ingrese un numero entero");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("entrada no valida por favor, ingrese un numero entero");
        Console.ResetColor();
    }




}

Console.WriteLine("mostrando el cuadrado de los antecesores de " + numero + ":");
int cont = 1;
while(cont < numero)
{
    Console.WriteLine("el cuadrado de " + cont + " es:" + Math.Pow(cont, 2));
    cont++;
}