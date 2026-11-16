string again = "a";
Console.Clear();
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání malého "a" tak i velkého "A"
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("****** Vykreslení trojúhelníku ********");
    Console.WriteLine("***************************************");
    Console.WriteLine("************ Vojtěch Rais *************");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");
    Console.WriteLine();

    // Vstup pro výšku (u pravoúhlého trojúhelníku určuje i šířku základny)
    Console.Write("Zadejte výšku trojúhelníku (celé kladné číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé kladné číslo! Zadejte výšku znovu (celé číslo): ");
        Console.ResetColor();
    }
       
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Výška trojúhelníku: {height}");
    Console.WriteLine("====================================");
    Console.WriteLine();
    
    // Začátek konkrétního algoritmu
    // Vnější cyklus, který se bude starat o vykreslení správného počtu řádků
    for(int i = 1; i <= height; i++)
    {
        if(i % 2 == 0)
        {
            // sudý řádek
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        } 
        else
        {
            // lichý řádek
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }         
        
        // Vnitřní cyklus: vykreslí tolik hvězdiček, kolikátý je právě řádek (j <= i)
        for(int j = 1; j <= i; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(75));
        }
        Console.WriteLine();
    }

    Console.ResetColor();
   
    // Konec konkrétního algoritmu
    
    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}