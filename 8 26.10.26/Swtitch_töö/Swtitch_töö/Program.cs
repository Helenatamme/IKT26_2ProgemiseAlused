using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Vali oma valik:\n\n1. Korruta 2 numbrit\n2. Kontrolli oma vanust\n3. Miau\n4. Välju (Exit)\n");
            Console.Write("Sinu valik: ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Sisesta esimene number.");
                    float firstNr = float.Parse(Console.ReadLine());
                    Console.WriteLine("Vali teine number");
                    float secondNr = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Korrutamise tulemus: {firstNr} * {secondNr} = {firstNr * secondNr}");
                    break;

                case 2:
                    Console.WriteLine("Mis on sinu vanus?");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number >= 0 && number <= 100 ? "Sinu number on " + number : "Liiga vana");
                    break;

                case 3:
                    Miau();
                    Console.WriteLine("Meetod kutsuti välja");
                    break;
            }

            Console.WriteLine("\nVajuta Enter, et jätkata...");
            Console.ReadLine();
        }
    }static void Miau()
    {
        Console.WriteLine("Miau");
    }
}