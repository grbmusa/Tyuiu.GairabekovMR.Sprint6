using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GairabekovMR.Sprint6.Task0.V25.Lib
{
    public class DataService : ISprint6Task0V25
    {
        public double Calculate(int x)
        {
            double res = x / Math.Sqrt(Math.Pow(x, 2) + x);
            return Math.Round(res, 3);
        }
    }
}