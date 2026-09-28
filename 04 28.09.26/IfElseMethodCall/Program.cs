namespace IfElseMethodCall
{
    internal class Program
    {
        //see on meetod Main
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada if ja else
            //kui kasutaja soovib, siis saab ta meetodi välja kutsuda
            Console.WriteLine("Kui soovid meetodit välja kutsuda, siis kirjuta ja");
            string vastus = Console.ReadLine();

            if(vastus =="ja")
            {
                HelloMethod();
            }
            else
            {
                Console.WriteLine("Meetodit ei kutsutud välja.");
            }
           
        }

        //tehke uus meetod nimega HelloMethod
        //Kirjutage sinna sisse kood,mis kuvab teksti Hello Kitty

        static void HelloMethod()
        {
            Console.WriteLine("Hello Kitty");
        }
    }
}
