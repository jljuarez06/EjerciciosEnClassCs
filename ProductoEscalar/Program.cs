int[] vector1 = new int [5];
int[] vector2 = new int [5];
int productoEscalar = 0;

Console.WriteLine("Ingrese los elementos del primer vector:");
for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.WriteLine($"Elemento {i + 1}:");
        vector1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingrese un número entero válido.");
        i--; // Reintentar la misma posición
    }
}
Console.WriteLine("Ingrese los elementos del segundo vector:");
for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.WriteLine($"Elemento {i + 1}:");
        vector2[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingrese un número entero válido.");
        i--; // Reintentar la misma posición
    }
}
  for (int i = 0; i < vector1.Length; i++)
    {
        productoEscalar += vector1[i] * vector2[i];
    }


Console.WriteLine("\nEl producto escalar es: " + productoEscalar);