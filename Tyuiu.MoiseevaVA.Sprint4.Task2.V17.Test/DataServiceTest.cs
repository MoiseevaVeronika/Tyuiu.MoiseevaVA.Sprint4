using Tyuiu.MoiseevaVA.Sprint4.Task2.V17.Lib;
namespace Tyuiu.MoiseevaVA.Sprint4.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numArray = { 3, 4, 5, 6, 7, 8, 9, 3, 4 };
            int res = ds.Calculate(numArray);
            int wait = 2835;
            Assert.AreEqual(wait, res);
        }
    }
}
