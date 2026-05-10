int[] vector1 = new int [5];
double sumaCuadrados = 0;

Console.WriteLine("Ingrese los elementos del vector:");
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
for (int i = 0; i < vector1.Length; i++)
{
    sumaCuadrados += Math.Pow(vector1[i], 2);
}
double magnitud = Math.Sqrt(sumaCuadrados);
Console.WriteLine("La magnitud del vector es: " + magnitud);
