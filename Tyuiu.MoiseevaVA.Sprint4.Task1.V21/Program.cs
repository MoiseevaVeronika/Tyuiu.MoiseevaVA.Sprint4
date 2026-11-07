using Tyuiu.MoiseevaVA.Sprint4.Task1.V21.Lib;
namespace Tyuiu.MoiseevaVA.Sprint4.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");
            int[] Array = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 };
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");
            int res = ds.Calculate(Array);
            Console.WriteLine("Произведение четных чисел=" + res);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
