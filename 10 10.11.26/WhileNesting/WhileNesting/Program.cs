namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb kasutada while ja omakorda while sisse panna while
            //While nesting
            //While kordab ennast 5 korda
            //vooskeem teha

            int a = 1;
            while (a<= 5)
            {
                int b = 1;
                while(b<= 5)
                {
                    //uus while kordab ennast 5 korda
                    Console.Write(b + " ");
                    b++;
                }

                Console.WriteLine();
                a++;
            }
        }
    }
}
