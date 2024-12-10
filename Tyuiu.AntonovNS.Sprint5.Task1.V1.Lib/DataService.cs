using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AntonovNS.Sprint5.Task1.V1.Lib
{
    public class DataService : ISprint5Task1V1
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            for (int i = startValue; i <= stopValue; i++)
            {
                double res = Math.Round((5 * i + 2.5) / (Math.Sin(i) + 2) + 2 * i + 2, 2);
                if (res == 0)
                {
                    File.AppendAllText(path, Convert.ToString(0));
                    File.AppendAllText(path, Convert.ToString("\n"));
                }
                else
                {
                    File.AppendAllText(path, Convert.ToString(res));
                    File.AppendAllText(path, Convert.ToString("\n"));
                }
            }
            return path;
        }
    }
}
