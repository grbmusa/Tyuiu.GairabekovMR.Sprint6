using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GairabekovMR.Sprint6.Task5.V17.Lib
{
    public class DataService : ISprint6Task5V17
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            var chiselki = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {
                for (int i = 0; i < 20; i++)
                {
                    double number = Convert.ToDouble(reader.ReadLine());

                    if (number < 0)
                    {
                        chiselki.Add(number);
                    }
                }
            }

            len = chiselki.ToArray().Length;

            return chiselki.ToArray();
        }
    }
}