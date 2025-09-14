using Tyuiu.BabenkovTO.Sprint1.Task1.V28.Lib;
namespace Tyuiu.BabenkovTO.Sprint1.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double i = 4.0;
            var res = ds.Calculate(i);
            Assert.AreEqual(1.6, res);
        }
    }
}
