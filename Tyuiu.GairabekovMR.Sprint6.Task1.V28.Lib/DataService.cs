using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GairabekovMR.Sprint6.Task1.V28.Lib
{
    public class DataService : ISprint6Task1V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = Math.Abs(startValue) + stopValue + 1;

            double[] result = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                result[count] = Math.Round((Math.Cos(i) + (4 * i) / (2) - Math.Sin(i) * 3 * i), 2);

                count++;
            }
            return result;
        }
    }








}