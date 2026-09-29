using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace _001_Operace_s_jednorozmernym_polem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Vytvoreni a naplneni pole
            Random random = new Random();
            int[] cisla = new int[10];

            for (int i = 0; i < cisla.Length; i++)
            {
                cisla[i] = random.Next(1, 101);
            }


            // vypsani pole
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < cisla.Length; i++)
            {
                Console.WriteLine(cisla[i]); 
            }


            //nalezeni minima a maxima
            int minimum;
            int maximum;

            minimum = cisla.Min();
            maximum = cisla.Max();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Nejvetsi cislo je " + maximum);
            Console.WriteLine("Nejmensi cislo je " + minimum);



            //prumer hodnot v poli
            double prumer = cisla.Average();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Prumer hodnot v poli je " + prumer);



            //razeni pole vzestupne
            Array.Sort(cisla);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Pole setridene vzestupne:");
            for (int i = 0; i < cisla.Length; i++)
            {
                Console.WriteLine(cisla[i] + " ");
            }
            Console.WriteLine("-------------------------------------");

        }
    }
}
