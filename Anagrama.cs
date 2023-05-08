using static System.Console;
namespace FinalCSharp;
public class Anagrama
{
    public void main()
    {
        WriteLine("Introduce la primera palabra");
        string? palabra1 = ReadLine();
        WriteLine("Introduce la segunda palabra");
        string? palabra2 = ReadLine();
        char[] letras1;
        char[] letras2;
        if (palabra1 != null && palabra2 != null)
        {
            letras1 = palabra1.ToLower().ToCharArray();
            letras2 = palabra2.ToLower().ToCharArray();
            Array.Sort(letras1);
            Array.Sort(letras2);

            bool sonAnagramas = letras1.SequenceEqual(letras2);

            if (sonAnagramas)
            {
                WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
            }
            else
            {
                WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
            }
        }



    }
}