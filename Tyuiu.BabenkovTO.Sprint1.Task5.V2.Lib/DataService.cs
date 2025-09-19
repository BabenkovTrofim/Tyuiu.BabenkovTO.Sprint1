using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BabenkovTO.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double res = (temp - 32) / (1.8);
            int result = Convert.ToInt32(res);
            return result;
        }
    }
}
