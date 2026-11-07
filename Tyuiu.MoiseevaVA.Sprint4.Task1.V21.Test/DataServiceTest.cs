using Tyuiu.MoiseevaVA.Sprint4.Task1.V21.Lib;
namespace Tyuiu.MoiseevaVA.Sprint4.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] Array = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 };
            int res = ds.Calculate(Array);
            int wait = 1769472;
            Assert.AreEqual(wait, res);

        }
    }
}
