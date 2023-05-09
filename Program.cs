using static System.Console;
using FinalCSharp;

string? opcion = "";

while (opcion != "fin")
{
    Console.WriteLine("Menú de opciones:");
    Console.WriteLine("1. MenorMayor()");
    Console.WriteLine("2. ParImpar()");
    Console.WriteLine("3. AnyoBisiesto()");
    Console.WriteLine("4. palindromo()");
    Console.WriteLine("5. ordenarLista()");
    Console.WriteLine("6. factorial()");
    Console.WriteLine("7. NumeroPrimo()");
    Console.WriteLine("8. AreaVolumenCubo()");
    Console.WriteLine("9. SumaNumerosPares()");
    Console.WriteLine("10. NumeroPositivoNegativoCero()");
    Console.WriteLine("11. MediaLista()");
    Console.WriteLine("12. AdivinarNumero()");
    Console.WriteLine("13. Anagrama()");
    Console.WriteLine("14. EliminarDuplicados()");
    Console.WriteLine("15. Capicua()");
    Console.WriteLine("Escriba 'fin' para salir del menú.");

    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            new MenorMayor().main();
            break;
        case "2":
            new ParImpar().main();
            break;
        case "3":
            new AnyoBisiesto().main();
            break;
        case "4":
            new Palindromo().main();
            break;
        case "5":
            new OrdenarLista().main();
            break;
        case "6":
            new Factorial().main();
            break;
        case "7":
            new NumeroPrimo().main();
            break;
        case "8":
            new AreaVolumenCubo().main();
            break;
        case "9":
            new SumaNumerosPares().main();
            break;
        case "10":
            new NumeroPositivoNegativoCero().main();
            break;
        case "11":
            new MediaLista().main();
            break;
        case "12":
            new AdivinarNumero().main();
            break;
        case "13":
            new Anagrama().main();
            break;
        case "14":
            new EliminarDuplicados().main();
            break;
        case "15":
            new Capicua().main();
            break;
        default:
            if (opcion != "fin")
                Console.WriteLine("Opción no válida.");
            break;
    }
    WriteLine("Presione cualquier tecla para continuar.");
    ReadKey();
    Clear();
}