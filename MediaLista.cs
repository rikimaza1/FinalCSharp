using static System.Console;
namespace FinalCSharp;
public class MediaLista
{
    public void main()
    {
        WriteLine("Cuantos valores quieres introducir");
        int cantidadValores = 0;
        if (int.TryParse(ReadLine(), out cantidadValores))
        {
            int[] numeros = new int[cantidadValores];
            for (int i = 0; i < cantidadValores; i++)
            {
                WriteLine($"Introduce el valor para {(i + 1)}");
                int entrada = 0;
                if (int.TryParse(ReadLine(), out entrada))
                    numeros[i] = entrada;
            }
            double media = numeros.Average();
            WriteLine("La media es: " + media);
        }
    }
}