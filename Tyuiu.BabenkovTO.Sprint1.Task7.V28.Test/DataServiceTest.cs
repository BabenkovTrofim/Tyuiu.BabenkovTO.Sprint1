using Tyuiu.BabenkovTO.Sprint1.Task7.V28.Lib;
namespace Tyuiu.BabenkovTO.Sprint1.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            double x = 2;
            double y = 25;
            DataService ds = new DataService();
            var wait = 625.787;
            Assert.AreEqual(wait, ds.Calculate(x, y));
        }
    }
}
