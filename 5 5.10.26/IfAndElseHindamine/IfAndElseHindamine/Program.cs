namespace IfAndElseHindamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lisa hinne");

            string input = Console.ReadLine();
            int number = int.Parse(input);
            if(number >= 0 && number <= 25)
            {
                Console.WriteLine("Sinu hinne on " + number);
            }
            else if(number >= 26 && number <= 50)
            {
                Console.WriteLine("Sinu hinne on " + number);
            }
            else if(number >= 51 && number <= 75)
            {
                Console.WriteLine("Sinu hinne on " + number);
            }
            else if( number >= 76 && number <= 100)
            {
                Console.WriteLine("Sinu hinne on " + number);
            }
            else
            {
                Console.WriteLine("Liiga suur hinne");
            }
        }
    }
}
