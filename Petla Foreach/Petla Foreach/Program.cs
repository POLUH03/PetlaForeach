using System;

class Program
{
    static void Main()
    {
        string[] pets = { "kot", "pies", "papuga", "świnka morska" };

        foreach (string zwierze in pets)
        {
            if (zwierze == "pies")
            {
                Console.WriteLine("Koniec");
                continue;
            }

            Console.WriteLine(zwierze);

            Console.ReadKey();
        }
    }
}
