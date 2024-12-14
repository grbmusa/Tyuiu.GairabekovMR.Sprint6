using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GairabekovMR.Sprint6.Task4.V28.Lib
{
    public class DataService : ISprint6Task4V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2.5 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round((Math.Cos(2 * x) + ((Math.Sin(x)) / (x + 2.5)) + 2 * x), 2);
                }
                valueArray[count] = y;
                count++;

            }
            return valueArray;

        }
    }
}