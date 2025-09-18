using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BabenkovTO.Sprint1.Task4.V3.Lib
{
    public class DataService : ISprint1Task4V3
    {
        public double Calculate(double x, double y)
        {
            var result = (Math.Sqrt(3 * x)) / Math.Pow(x - y, 2);
            return Math.Round(result, 3);
        }
    }
}
