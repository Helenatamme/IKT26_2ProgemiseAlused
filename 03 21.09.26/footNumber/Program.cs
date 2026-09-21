namespace footNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teha jalanumbri suurustest üks if ja else harjutus.
            //Esimene tingimus on jalanumbri 30-33(siin on tekst roheline),
            //teine jalanumbri 34-38(siin on tagataust valge),
            //kolmas jalanumbri 39-44( siin on tekst sinine ja tagataust kollane,
            //neljas jalanumbri 45-48(siin teeb arvuti häält beep)
            //Kindlasti tuleb ära lahendada olukord,
            //kus kasutatakse mõnda teist jalanumbrit.
            Console.WriteLine("Sisesta jalanumber");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number >= 30 && number <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (number >= 34 && number <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            else if (number >= 39 && number <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else if (number >= 45 && number <= 48)
            {
                Console.Beep();
                Thread.Sleep(1000);
            }
            else 
            {
                Console.WriteLine(" Liiga suur jalanumber");
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }
    }
}
