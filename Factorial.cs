using static System.Console;
using static System.Math;
namespace FinalCSharp;
public class Factorial
{
    public void main()
    {
        int num = 0, factorial = 1;

        Write("Introduce un número entero positivo: ");
        if (int.TryParse(ReadLine(), out num))
        {

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            WriteLine("El factorial de {0} es {1}", num, factorial);
        }
        else
            WriteLine("Número inválido");

        ReadKey();
    }

}