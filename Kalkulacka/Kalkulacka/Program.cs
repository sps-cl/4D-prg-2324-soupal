using System;

public interface Calculator
{
    double Plus(double x, double y);
    double Minus(double x, double y);
    double Krat(double x, double y);
    double Div(double x, double y);
}

public class Kalkulacka : Calculator
{
    public double Plus(double x, double y)
    {
        return x + y;
    }

    public double Minus(double x, double y)
    {
        return x - y;
    }

    public double Krat(double x, double y)
    {
        return x * y;
    }

    public double Div(double x, double y)
    {
        if (y == 0)
        {
            Console.WriteLine("Nelze dělit nulou!");
        }

        return x / y;
    }
}

class Program
{
    static void Main()
    {
        Kalkulacka kalkulacka = new Kalkulacka();

        Console.WriteLine("1. Sčítání");
        Console.WriteLine("2. Odčítání");
        Console.WriteLine("3. Násobení");
        Console.WriteLine("4. Dělení");
        Console.Write("Vybete operaci (1/2/3/4): ");

        int volba = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadej prvni cislo: ");
        double x1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadej druhe cislo: ");
        double y1 = int.Parse(Console.ReadLine());

        double vysledek = 0;

        switch (volba)
        {
            case 1:
                vysledek = kalkulacka.Plus(x1, y1);
                break;
            case 2:
                vysledek = kalkulacka.Minus(x1, y1);
                break;
            case 3:
                vysledek = kalkulacka.Krat(x1, y1);
                break;
            case 4:
                vysledek = kalkulacka.Div(x1, y1);
                break;
            default:
                Console.WriteLine("Špatná volba!");
                return;
        }
        Console.WriteLine("Výsledek: " + vysledek);

        Console.ReadKey();
    }
}