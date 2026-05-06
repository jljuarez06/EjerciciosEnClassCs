//leer 5 edades y mostrar la edad promedio
int[] edades = new int[5];
int suma = 0;
double promedio = 0;

for(int i = 0; i < edades.Length; i++)
{
    try
    {
        Console.WriteLine("Ingrese la edad " + (i + 1) + ":");
        edades[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Debe ingresar un número entero. Intente nuevamente.");
        i--; // Decrementar el índice para volver a solicitar la edad
    }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
            i--; // Decrementar el índice para volver a solicitar la edad
        }
}

foreach(int edad in edades)
{
    suma += edad;
} 
promedio = (double)suma / edades.Length;

Console.WriteLine("La edad promedio es: " + promedio);