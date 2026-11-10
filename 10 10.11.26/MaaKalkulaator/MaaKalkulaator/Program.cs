namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Meil on münt, mille diameeter on 25.75 mm
            //Arvutada välja Maa ümbemõõt ja mitu münti
            // Mahub järjestikku ümber Maa
            //Arvutuses tohib kasutada ainult mündi diameetri ja maa raadiust 6371km

            double Maaraadius = 637100;//km meetriteks 
            double Maaümbermõõt = 2 * 3.14 * Maaraadius;
            double Mündidiameeter = 0.02575;// mm meetriteks
            double MüntMaa = Maaümbermõõt/ Mündidiameeter;

            Console.WriteLine("Maa ümbermõõt " + Maaümbermõõt);
            Console.WriteLine("Mitu münti ümber Maa " + MüntMaa);

           
        }
    }
}
