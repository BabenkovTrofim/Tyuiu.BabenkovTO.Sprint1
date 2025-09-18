using Tyuiu.BabenkovTO.Sprint1.Task4.V3.Lib;
namespace Tyuiu.BabenkovTO.Sprint1.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalc()
        {
            double x = 27;
            double y = 16;
            DataService ds = new DataService();
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.074, res);
        }
    }
}
