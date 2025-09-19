using Tyuiu.BabenkovTO.Sprint1.Task5.V2.Lib;
namespace Tyuiu.BabenkovTO.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            double f = 75;
            int c = ds.FahrenheitToСelsius(f);
            int wait = 24;
            Assert.AreEqual(wait, c);
        }
    }
}
