using Tyuiu.BabenkovTO.Sprint1.Task0.V24.Lib;
namespace Tyuiu.BabenkovTO.Sprint1.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
