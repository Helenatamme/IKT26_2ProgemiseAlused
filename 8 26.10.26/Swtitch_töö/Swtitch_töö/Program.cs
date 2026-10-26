namespace Swtitch_töö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number.");
            float firstNr = float.Parse(Console.ReadLine());

            Console.WriteLine("Tuleb korrutamise tehe, vajuta *");
            string input = Console.ReadLine();

            Console.WriteLine("Vali teine number");
            float secondNr = float.Parse(Console.ReadLine());

            switch(input)
            {
                case "*":
                    Console.WriteLine($"Korrutamise tulemus: {firstNr} * {secondNr} = {firstNr} * {secondNr}");
                    break;

                default:
                    Console.WriteLine("Valisid vale märgi");
                    break;

            }
            Console.WriteLine("Mis on sinu vanus?");
            int number = int.Parse(Console.ReadLine());

            switch(number)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("Sinu number on"+ number);
                    break;
                default:
                    Console.WriteLine("Liiga vana");
                    break;
            }

            Console.WriteLine("Sisesta meetod");

                    string meetod = Console.ReadLine();
            switch(meetod)
            {
                case "meetod":
                  Console.WriteLine("Miau");
                    Console.WriteLine("Meetod kutsuti välja");
                    break;
                default:
                    Console.WriteLine("Meetodit ei kutsutud välja");
                    break;

            }
        }
    }
}
