namespace ForLoopAdding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta korduste arv");
            Console.WriteLine("--------------------");
            Console.WriteLine("\n\n");

            int arv = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < arv; i++ )
            {
                Console.WriteLine(" See on rida nr {0}", i);

                for ( int j = 1; j <= 2; j++);
                {
                    Console.WriteLine("kill- koll");
                }

                Console.WriteLine("Killadi-koll");
            }
        }
    }
}
