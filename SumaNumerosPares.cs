using static System.Console;
using static System.Math;
namespace FinalCSharp;
public class SumaNumerosPares
{
    public void main()
    {
        List<int> numeros = new List<int>();
        string? entrada;
        do
        {
            WriteLine("Introduce los numero a comprobar y sumar, para terminar de introducir numero escriba fin");
            entrada = ReadLine();
            if (entrada == "fin")
                WriteLine("No mas numeros");
            else
            {
                {
                    int entero;
                    if (int.TryParse(ReadLine(), out entero))
                        numeros.Add(entero);
                }
            }


        } while (entrada != "fin");

        int suma = 0;

        foreach (int num in numeros)
        {
            if (num % 2 == 0)
                suma += num;
        }

        WriteLine("La suma de los números pares es {0}", suma);

        ReadKey();
    }
}