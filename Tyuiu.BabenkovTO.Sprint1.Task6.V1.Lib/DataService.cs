using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BabenkovTO.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            var Char = Convert.ToUInt32(value[0]);
            return Char.ToString();
        }
    }
}
