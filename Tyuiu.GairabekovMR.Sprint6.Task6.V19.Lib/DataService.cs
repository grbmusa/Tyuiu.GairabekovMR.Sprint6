using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GairabekovMR.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
        {
            string[] liner;
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    liner = line.Trim().Split(' ');
                    foreach (string c in liner)
                    {
                        if (c.Contains('l'))
                        {
                            resStr += " " + c;
                        }
                    }

                }
            }
            return resStr.Trim();
        }


    }
}