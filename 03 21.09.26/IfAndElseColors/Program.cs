namespace IfAndElseColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Teha if ja else konsoolirakendus, kus" + "konrollitakse stringi abil värvi vastavust");

            Console.WriteLine("Värvide valikus on: red,blue,green ja white");
            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta" + " eelpool sisestatud värvi");

            string input = Console.ReadLine();
            int age = int.Parse(input);

            if(age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Blue;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }
    }
}
