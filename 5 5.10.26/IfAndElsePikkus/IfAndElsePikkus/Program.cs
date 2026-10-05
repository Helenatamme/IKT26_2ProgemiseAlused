namespace IfAndElsePikkus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta pikkus");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number >= 40 && number <= 80)
            {
                Console.WriteLine("Sinu pikkus on " + number);
            }
            else if (number >= 81 && number <= 130)
            {
                Console.WriteLine("Sinu pikkus on " + number);
            }
            else if (number >= 131 && number <= 170)
            {
                Console.WriteLine("Sinu pikkus on " + number);
            }
            else
            {
                Console.WriteLine("Liiga suur");
            }
        }

    }
}
