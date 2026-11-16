using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MoiseevaVA.Sprint4.Task6.V19.Lib
{
    public class DataService : ISprint4Task6V19
    {
        public int Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, k => k.Length > 5);
            return res.Length;
        }
    }
}
