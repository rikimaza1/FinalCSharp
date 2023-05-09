using static System.Console;
namespace FinalCSharp;
public class MenorMayor
{
    public void main()
    {

        WriteLine("Introduzca cantidad de numeros a entrar");
        int cantidadNumeros;
        if (int.TryParse(ReadLine(), out cantidadNumeros))
        {
            int[] numeros = new int[cantidadNumeros];
            int entrada;
            for (int i = 0; i < cantidadNumeros; i++)
            {
                WriteLine($"Introduce el Numero {(i + 1)}");
                if (int.TryParse(ReadLine(), out entrada))
                    numeros[i] = entrada;


            }

            int mayor = numeros[0];
            int menor = numeros[0];

            foreach (int numero in numeros)
            {
                if (numero > mayor)
                {
                    mayor = numero;
                }
                else if (numero < menor)
                {
                    menor = numero;
                }
            }
            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("El número menor es: " + menor);
        }
    }
}