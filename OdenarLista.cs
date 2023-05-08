using static System.Console;
namespace FinalCSharp;
internal class OrdenarLista
{
    public void main()
    {

        WriteLine("Cuantos nombre quieres añadir");
        int cantidadNombres = 0;
        if (int.TryParse(ReadLine(), out cantidadNombres))
        {
            string[] nombres = new string[cantidadNombres];
            for (int i = 0; i < cantidadNombres; i++)
            {
                WriteLine($"Introduce el nombre {(i + 1)}");
                String? entrada = ReadLine();
                if (entrada != null)
                    nombres[i] = entrada;


            }

            Array.Sort(nombres);

            WriteLine("Lista ordenada alfabéticamente:");

            foreach (string nombre in nombres)
            {
                WriteLine(nombre);
            }
        }
    }
}