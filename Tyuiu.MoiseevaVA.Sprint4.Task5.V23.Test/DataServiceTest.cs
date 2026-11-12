using Tyuiu.MoiseevaVA.Sprint4.Task5.V23.Lib;
namespace Tyuiu.MoiseevaVA.Sprint4.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] { { -4,6,5,-3,3 },
                            { 5,7,4,6,4},
                            { 1,-2,4,1,5 },
                            { 1,7,-2,5,7 },
                            { 4,2,6,5,6 } };
            int[,] res = ds.Calculate(mas);
            int[,] wait={ { 0,6,5,0,3 },
                            { 5,7,4,6,4},
                            { 1,0,4,1,5 },
                            { 1,7,0,5,7 },
                            { 4,2,6,5,6 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
