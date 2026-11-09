namespace ComputerLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, kalkulatsioon!");

            double calculatsion1 = 3 + 8 / (4 - 2) * 4;
            double calculatsion2 = 3 + 8 / 4 - 2 * 4;
            double calculatsion3 = (3 + 8) / (4 - 2) * 4;
            // kui tahad, et võtaks arvesse komakohta, siis pane nr lõppu .0
            double calculatsion4 = (3.0 + 8.0) / (4.0 - 2.0) * 4.0;


            Console.WriteLine("3 + 8 / (4 - 2) * 4 = " + calculatsion1);
            Console.WriteLine("3 + 8 / 4 - 2 * 4 = " + calculatsion2);
            // Annab vastuseks 20, aga peaks olema 22
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 =" + calculatsion3);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = "+ calculatsion4);
        }
    }
}
