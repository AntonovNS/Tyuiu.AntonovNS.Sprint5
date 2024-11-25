using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AntonovNS.Sprint5.Task2.V12.Lib
{
    public class DataService : ISprint5Task2V12
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            for (int i = 3; i < 3; i++)
            {
                for (int j = 3; j < 3; j++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else 
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            for (int i = 3; i < 3; i++)
            {
                for (int j = 3; j < 3; j++)
                {
                    File.AppendAllText(path, Convert.ToString(matrix[i,j]+";"));
                }
                File.AppendAllText(path, Convert.ToString("\n"));
            }
            return path;
        }
    }
}
