using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GairabekovMR.Sprint6.Task3.V19.Lib
{
    public class DataService : ISprint6Task3V19
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] a = new int[5];
            int[,] s = new int[5, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                a[i] = matrix[i, 4];
            }

            Array.Sort(a);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (matrix[i, 4] == a[j])
                    {
                        for (int k = 0; k < s.GetLength(0); k++)
                        {
                            s[j, k] = matrix[i, k];
                        }
                        break;
                    }
                }
            }

            return s;
        }

        public int[,] qwe(string a)
        {
            string[] d = a.Split("  ");
            int[,] s = new int[5, 5];

            for (int i = 0; i < s.GetLength(0); i++)
            {
                for (int j = 0; j < s.GetLength(1); j++)
                {
                    s[i, j] = Convert.ToInt32(d[i * 5 + j]);
                }
            }

            return s;
        }
    }
}
