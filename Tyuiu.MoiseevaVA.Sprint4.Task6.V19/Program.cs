using Tyuiu.MoiseevaVA.Sprint4.Task6.V19.Lib;
namespace Tyuiu.MoiseevaVA.Sprint4.Task6.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");
            var k = new string[] { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < k.Length; i++)
            {
                Console.WriteLine(k[i]);
            }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");
            int res = ds.Calculate(k);
            Console.WriteLine("Кол-во названий длиной больше 5="+res);
            Console.ReadKey();
            
        }
    }
}
