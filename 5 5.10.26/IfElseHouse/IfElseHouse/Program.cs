namespace IfElseHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta maja suurus ruutmeetrites");

            int houseSize = int.Parse(Console.ReadLine());

            if (houseSize >= 0 && houseSize <= 40)
            {
                Console.WriteLine($" Sinu maja suurus on {houseSize} m2 ");
            }
            else if( houseSize >= 41 && houseSize <= 90)
            {
                Console.WriteLine($" Sinu maja suurus on {houseSize} m2");
            }
            else if(houseSize >= 91 && houseSize <= 130)
            {
                Console.WriteLine($" Sinu maja suurus on {houseSize} m2");
            }
            else if(houseSize >= 131)
            {
                Console.WriteLine($" Sinu maja suurus on {houseSize} m2");
            }
            else
            {
                Console.WriteLine("Sisestatud väärtus ei ole kehtiv");
            }
        }
    }
}
