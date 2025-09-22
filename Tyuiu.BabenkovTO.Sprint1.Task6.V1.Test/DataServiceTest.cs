using Microsoft.Testing.Platform.MSBuild;
using System.Net.Http.Headers;
using Tyuiu.BabenkovTO.Sprint1.Task6.V1.Lib;
namespace Tyuiu.BabenkovTO.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string a = "1";
            DataService ds = new DataService();
            int res = Convert.ToInt32(ds.SymbolCode(a));
            Assert.AreEqual(49, res);
        }
    }
}
