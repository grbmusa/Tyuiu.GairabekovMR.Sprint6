using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GairabekovMR.Sprint6.Task3.V19.Lib
{
    public class DataService : ISprint6Task3V19
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int min = 0;
            int a = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 4)
                    {
                        if (i == 0)
                        {
                            min = matrix[i, j];
                        }
                        else
                        {
                            if (matrix[i, j] < min)
                            {
                                matrix[i - 1, j] = matrix[i, j];
                                matrix[i, j] = min;
                                min = matrix[i - 1, j];
                            }
                            else
                            {
                                if (matrix[i, j] < matrix[i - 1, j])
                                {
                                    a = matrix[i - 1, j];
                                    matrix[i - 1, j] = matrix[i, j];
                                    matrix[i, j] = a;

                                }
                            }
                        }
                    }

                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 4)
                    {
                        if (i == 0)
                        {
                            min = matrix[i, j];
                        }
                        else
                        {
                            if (matrix[i, j] < min)
                            {
                                matrix[i - 1, j] = matrix[i, j];
                                matrix[i, j] = min;
                                min = matrix[i - 1, j];
                            }
                            else
                            {
                                if (matrix[i, j] < matrix[i - 1, j])
                                {
                                    a = matrix[i - 1, j];
                                    matrix[i - 1, j] = matrix[i, j];
                                    matrix[i, j] = a;

                                }
                            }
                        }
                    }

                }
            }
            return matrix;
        }
    }
}