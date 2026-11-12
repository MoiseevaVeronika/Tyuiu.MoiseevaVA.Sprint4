using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoiseevaVA.Sprint4.Task4.V10.Lib
{
    public class DataService : ISprint4Task4V10
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i,j]%2!=0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
