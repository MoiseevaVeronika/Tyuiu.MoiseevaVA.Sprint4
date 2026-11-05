using Tyuiu.MoiseevaVA.Sprint4.Task0.V21.Lib;
namespace Tyuiu.MoiseevaVA.Sprint4.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numArray = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };
            int res = ds.GetSumEvenArrEl(numArray);
            int wait = 36;
            Assert.AreEqual(wait, res);

        }
    }
}
