namespace IfAnsElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi");

            //siin on muutuja nimega name,
            //mis on tüübiga string
            //loeb andmeid konsoolis ja salvestab
            //need muutuja name sisse
            string name = Console.ReadLine();

            if (name!="")
            { 
                Console.WriteLine("Tere," + name);
            }
            else
            {
                Console.WriteLine("Tere, tundmat");
            }
        }
    }
}
