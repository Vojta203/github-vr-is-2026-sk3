
string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();

    Console.WriteLine("***************************************");
    Console.WriteLine("*********** Součet cifer **************");
    Console.WriteLine("*********** Vojtěch Rais **************");
    Console.WriteLine("***************************************");

    // Zadání čísla
    Console.Write("\nZadejte celé číslo: ");

    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte znovu: ");
    }

    int numberBackup = number;
    int sum = 0;

    if (number < 0)
    {
        number = number * -1;
    }

    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    // Výpis výsledku
    Console.WriteLine();
    Console.WriteLine("==============================");
    Console.WriteLine("Součet cifer čísla " + numberBackup + " je " + sum);
    Console.WriteLine("==============================");

    // Opakování programu
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? (a): ");

    again = Console.ReadLine() ?? "";
}
