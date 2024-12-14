using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GairabekovMR.Sprint6.Task7.V19.Lib
{
    public class DataService : ISprint6Task7V19
    {
        public int[,] GetMatrix(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line[j]);
                }
            }

            for (int j = 0; j < columns; j++)
            {
                if (matrix[1, j] % 2 == 0)
                {
                    matrix[1, j] = 2;
                }
            }

            return matrix;
        }

    }
}