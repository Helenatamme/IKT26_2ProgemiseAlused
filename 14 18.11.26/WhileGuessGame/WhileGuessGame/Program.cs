namespace WhileGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Paku number vahemikus 1-100 või muidu!");
            Console.ForegroundColor = ConsoleColor.Gray;

            //numbri arvamise mäng

            Random random = new Random();
            int secretNr = random.Next(1, 101);
            int guess = 0;
            int attempts = 1;

            //tuleb kasutada while, kus öeldakse, kas sinu pakutud number oli suurem või väiksem

            while (secretNr != guess)
            {
                guess = int.Parse(Console.ReadLine());
                Console.WriteLine("Katseid: " + attempts);
                if (guess > secretNr)
                {
                    Console.WriteLine("Vastus on väiksem kui " + guess);
                }
                else if (guess < secretNr)
                {
                    Console.WriteLine("Vastus on suurem kui " + guess);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Õige vastus! Juhhu!!");
                }
                attempts++;
            }
        }
    }
}
