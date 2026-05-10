int[] vector1 = new int [5];
int[] vector2 = new int [5];
int[] restavector = new int [5];

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
        i--; 
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
        i--; 
    }
}
for (int i = 0; i < restavector.Length; i++)
{
    restavector[i] = vector1[i] - vector2[i];
}
Console.WriteLine("La resta de los dos vectores es:");
for (int i = 0; i < restavector.Length; i++)

{
    Console.WriteLine($"Elemento {i + 1}: {restavector[i]}");
}
