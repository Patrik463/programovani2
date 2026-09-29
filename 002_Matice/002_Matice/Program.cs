namespace _002_Matice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // incializace matic a jeji vyplnění nahodymi cisly
            int[,] matice = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matice[i, j] = random.Next(1, 51);
                }
            }

            // vypsani matice
            for (int i = 0; i < matice.GetLength(0); i++)
            {
                for (int j = 0; j < matice.GetLength(0); j++)
                {
                    Console.Write(matice[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // nalezeni maxima a minima v matici
            int max = matice[0, 0];
            int min = matice[0, 0];

            Console.WriteLine("minimalni hodnota: " + min);
            Console.WriteLine("maximalni hodnota: " + max);

            //vypsani součtu hodnot v poli
            int soucet = 0;
            for(int i = 0;i< matice.GetLength(0);i++)
            {
                for(int j = 0;j< matice.GetLength(0);j++)
                {
                    soucet += matice[i, j];
                }
            }
            Console.WriteLine("součet hodnot v matici: " + soucet);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //vypsani hlavni diagonali
            //Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < matice.GetLength(0); i++)
            {
                for (int j = 0; j < matice.GetLength(0); j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(matice[i, j] + "\t");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (i!=j)
                    {
                        Console.Write(matice[i, j] + "\t");
                    }
                    
                }
                Console.WriteLine(" ");
            }
            //Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}
