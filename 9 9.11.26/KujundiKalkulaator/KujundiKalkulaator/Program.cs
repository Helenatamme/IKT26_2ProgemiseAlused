namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta nr");

            //Ruudu sees asub ring. Ringi raadius on 3 ühikut.
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt.

            double raadius = double.Parse(Console.ReadLine());
            double diameeter = raadius * 2;
            double pindala = diameeter * diameeter;
            double ümbermõõt = diameeter * 4;

            Console.WriteLine(" Ruudu diameeter: " + diameeter);
            Console.WriteLine("Ruudu pindala: " + pindala);
            Console.WriteLine(" Ruudu ümbermõõt: " + ümbermõõt);

            // arvuta ringi pindala ja ümbermõõt
            // pindala pi * r2, ümbermõõt 2* pi * r

            Console.WriteLine("Sisesta ringi raadius");

            double raadius2 = double.Parse(Console.ReadLine());
            double pindala2 = 3.14 * (raadius2 * raadius2);
            double ümbermõõt2 = 2 * 3.14 * raadius2;

            Console.WriteLine("Ringi pindala: " + pindala2);
            Console.WriteLine("Ringi ümbermõõt: " + ümbermõõt2);

            // double eoundArea = Math.PI * Math.Pow (roundRadius, 2) 
            // Math. pi on üks pi kasutamise võimalustest

            //Kuidas teha, et maksimaalselt 2 kohta pärast koma oleks.( pärast kui kasutada Math.PI)
            //Nt Math.Round nt (roundArea1 , 2) ehk sulud ümber ja ,2 on kaks koma kohta.
            //{roundarea1 : 0. ##} ja lause alguses on ka $. # määrab kui palju komakohti.

        }
    }
}
