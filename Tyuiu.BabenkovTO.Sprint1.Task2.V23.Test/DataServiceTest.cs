using Tyuiu.BabenkovTO.Sprint1.Task2.V23.Lib;
namespace Tyuiu.BabenkovTO.Sprint1.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int min = 3;
            DataService ds = new DataService();
            int sec = ds.ConvertMinutesToSeconds(min);
            Assert.AreEqual(180, sec);
        }
    }
}
