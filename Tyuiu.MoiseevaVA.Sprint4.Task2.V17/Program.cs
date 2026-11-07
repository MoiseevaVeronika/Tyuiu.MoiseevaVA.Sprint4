using Tyuiu.MoiseevaVA.Sprint4.Task2.V17.Lib;
namespace Tyuiu.MoiseevaVA.Sprint4.Task2.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введние кол-во элемепнтов массива");
            int Len = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[Len];

            for (int i = 0; i < Len; i++)
            {
                numArray[i] = rnd.Next(3, 10);
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < Len; i++)
            {
                Console.WriteLine(numArray[i] + "\t");

            }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");
            int res = ds.Calculate(numArray);
            Console.WriteLine("Произведение нечетных элементов массива=" + res);
            Console.ReadKey();
        }
    }
}

