using static System.Console;
namespace FinalCSharp;
internal class EliminarDuplicados
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
                int entero;
                if (int.TryParse(ReadLine(), out entero))
                    numeros.Add(entero);
            }

        } while (entrada != "fin");

        List<int> numerosSinDuplicados = new List<int>();

        foreach (int numero in numeros)
        {
            if (!numerosSinDuplicados.Contains(numero))
            {
                numerosSinDuplicados.Add(numero);
            }
        }

        WriteLine("Números originales: " + string.Join(", ", numeros));
        WriteLine("Números Sin duplicar: " + string.Join(", ", numerosSinDuplicados));
    }
}