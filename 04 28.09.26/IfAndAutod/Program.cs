using System.Threading.Channels;

namespace IfAndAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali automark!");
            //Kasutada if and else
            //kirjuta automark
            //valikus on BMW,Audi, Porsche ja Skoda
            //Kui valitakse Skoda, siis seal sees on uuesti küsimus, et
            //mis mudelit soovid valida.Mudeli valikus Kodiaq ja Octavia
            Console.WriteLine("BMW,Audi,Porsche ja Skoda");

            string automark = Console.ReadLine();

            if (automark == "BMW")
            {
                Console.WriteLine("See on BMW");
            }
            else if (automark == "Audi")
            {
                Console.WriteLine("See on Audi");

            }
            else if (automark == "Porsche")
            {
                Console.WriteLine("See on Porsche");
            }
            else if (automark == "Skoda")
            {
                Console.WriteLine("Vali mudel Kodiaq või Octavia");
                string mudel = Console.ReadLine();
                if (mudel == "Kodiaq")
                {
                    Console.WriteLine("Hea valik!");
                }
                else if (mudel == "Octavia")
                {
                    Console.WriteLine("Super valik!");
                }
                else
                {
                    Console.WriteLine(" Pole täna valikus");
                }
            }
            else
            {
                Console.WriteLine("Mingi muu automark");
            }
           
        }
        
    }
}
