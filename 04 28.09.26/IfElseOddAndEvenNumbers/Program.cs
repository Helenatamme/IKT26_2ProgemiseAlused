namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta number");
            //konsool küsib numbrit
            //number tuleb ära parsida

            //if ja else juures toimub kontroll, et
            //kas on paaris või paaritu nr
            //mida % operaator tähendab
            //see leiab jäägi ja nii kaua kontrollib, kas on 0

            string input = Console.ReadLine();
            int number = int.Parse(input);

            if(number % 2 == 0)
            {
                Console.WriteLine("Arv on paaris");
                EvenNumberMethod();
            }
            else
            {
                Console.WriteLine("Arv on paaritu");
                OddNumberMethod();
            }
            // kutsuda paarisarvu ja paarituarvu tekst välja
            //läbi meetodi kutsumise
        }
        static void OddNumberMethod()
        {
            Console.WriteLine("Paarituarv");

        }
        static void EvenNumberMethod()
        {
            Console.WriteLine("Paarisarv");
        }
    }
}
