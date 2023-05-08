namespace FinalCSharp;
public class MenorMayor
{
    public void main()
    {
        int[] numeros = { 5, 3, 8, 1, 7, 2 };
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