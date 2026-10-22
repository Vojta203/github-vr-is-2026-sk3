//nejprve budeme řešit opakování programu
Console.Clear();
string again = "a";

// ToLower() převede vztup na malá písmena, takže bude fungovat jak a tak A
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("********* Výpis řady **********");
    Console.WriteLine("*******************************");
    Console.WriteLine("******** Vojtěch Rais *********");
    Console.WriteLine("*******************************");
    Console.Write("");
    
    /* Vstup počáteční hodnoty - špatně řešený
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first = int.Parse(Console.ReadLine()); 
    */

    // Vstup počáteční hodnoty - správně řešený
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte CELÉ číslo znovu: ");
    }

    // Vztup konečné hodnoty
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte CELÉ číslo znovu: ");
    }

    // Vstup pro diferenci s kontrolou na kladnou hodnotu
    Console.Write("Zadejte diference (kladné celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Nezadali jste kladné celé číslo! Zadejte diferenci znovu (celé číslo): ");
    }

    //rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("============================================");
    // Proměnné vypsané pod sebou
    // Console.WriteLine($"První číslo: {first}");
    // Console.WriteLine($"Poslední číslo: {last}");
    // Console.WriteLine($"Diference (krok): {step}");
    Console.WriteLine($"První číslo řady: {first}; Poslední číslo: {last}; Diference (krok): {step}");


    Console.WriteLine("============================================");
    Console.WriteLine();


    //Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");
    Console.WriteLine("");
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}