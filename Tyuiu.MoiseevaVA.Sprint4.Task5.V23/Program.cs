using Tyuiu.MoiseevaVA.Sprint4.Task5.V23.Lib;
namespace Tyuiu.MoiseevaVA.Sprint4.Task5.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++) 
                {
                    matrix[i, j] = rnd.Next(-4, 9);
                }
            }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++) 
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] res = ds.Calculate(matrix);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++) 
                {
                    Console.Write(res[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}




