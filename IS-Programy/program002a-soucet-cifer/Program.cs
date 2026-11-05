string again = "a";
Console.Clear();
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání malého "a" tak i velkého "A"
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("*********** Součet cifer **************");
    Console.WriteLine("***************************************");
    Console.WriteLine("*********** Vojtěch Rais **************");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");
    Console.WriteLine();

    // Vstup celočíselné hodnoty
    Console.Write("Zadejte celé číslo: ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte číslo znovu: ");
    }
    
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    // Proměnné vypsané vedle sebe
    Console.WriteLine($"Zadané číslo: {number}");
    Console.WriteLine("====================================");
    Console.WriteLine();
    

    // Začátek konkrétního algoritmu

    //3. Připrava pomocných proměnných pro vyřešení problému
    int numberBackup = number;  //Záloha zadaného čísla pro závěrečný výpis
    int sum = 0;                //neutrální hodnota pro sčítaní je 0
    int digit;                  //proměnná pro uchování aktuální cifry

    //4. Ošetření záporných čísel
    if (number < 0)
    {
        number = -number;
    }

    //5. zvláštní případ pro nulu
    if (number == 0)
    {
        sum = 0;
    } else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na jednotlivé číslice (z prava do leva)");

        //6. Matematický rozklad čísla v cyklu while
        while (number > 0)
        {
            // % je MODUO - zbytek po celočíselném dělení
            digit = number % 10; // MODULO 10 získá poslední číslici
            sum = sum + digit; // přičtení číslice k celkovému součtu
            number = number / 10;

            Console.WriteLine($"Aktuální číslice (zbytek): {digit}");
            Console.WriteLine($"Aktuální hodnota součtu : {sum}");
            Console.WriteLine($"Číslo po oříznutí poslední číslice: {number}");

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine($"součet cifer čísla {numberBackup} je {sum}");

            Console.WriteLine("==================================");
            Console.WriteLine();

        }
    }




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


