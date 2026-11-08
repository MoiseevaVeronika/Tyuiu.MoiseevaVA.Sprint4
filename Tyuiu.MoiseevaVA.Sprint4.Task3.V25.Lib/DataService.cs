using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoiseevaVA.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1; //говорит, какой у массива последний символ +1 т.к с 0
            int count = 1;
            for (int i=0; i<rows; i++)
            {
                count *= array[i, 3]; //произведение в 4 столбце (третий индекс)
            }
            return count;
        }
    }
}
