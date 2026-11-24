using System.Numerics;

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary!");

            Console.WriteLine(" Sisesta number: ");

            int number = Convert.ToInt32(Console.ReadLine());
            string binaryNumber = "";

            while (number > 0)
            {
                int reminder = number % 2;
                binaryNumber = reminder + binaryNumber;
                number /= 2;
            }
            Console.WriteLine(binaryNumber);
        }
    }
}
