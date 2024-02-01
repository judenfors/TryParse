using System;

class Program
{
    static void Main(string[] args)
    {
        int resultat;
        if(!TryParse(Console.ReadLine(), out resultat))
        {
            Console.WriteLine("Skriv in en siffra");
        }
        else
        {
            Console.WriteLine(resultat);
        }
    }

    public static bool TryParse(string s, out int resultat)
    {
        try
        {
            resultat = int.Parse(s);
            return true;
        }

        catch
        {
            resultat = -1;
            return false;
        }
    }
}