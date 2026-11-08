using Tyuiu.MoiseevaVA.Sprint4.Task3.V25.Lib;
namespace Tyuiu.MoiseevaVA.Sprint4.Task3.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { 7, 3, 5, 3, 6 },
                                       { 4, 6, 2, 5, 7 },
                                       { 2, 3, 3, 3, 5 },
                                       { 2, 7, 7, 6, 2 },
                                       { 6, 6, 4, 3, 6 } };
            int rows = mas2.GetUpperBound(0) + 1;
            int colums = mas2.Length / rows;

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Массив");
            for (int i = 0; i < rows; i++)
            {
                for (int j=0; j<colums;j++)
                {
                    Console.Write(mas2[i, j]);
                }
                Console.WriteLine();
            }


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");
            int res = ds.Calculate(mas2);
            Console.WriteLine("Произведение элементов:" + res);
            Console.ReadKey();

        }
    }
}
