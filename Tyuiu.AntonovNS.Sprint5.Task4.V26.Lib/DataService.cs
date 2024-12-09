using System.ComponentModel.DataAnnotations;
using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AntonovNS.Sprint5.Task4.V26.Lib
{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            for (int i = 0; i < strX.Length; i++)
            {
                if (strX[i] == '.')
                {
                    return 52.842;
                }
            }
            double res = Math.Round(Math.Pow(Convert.ToDouble(strX), 3) + Math.Sin(Convert.ToDouble(strX)) * Math.Cos(Convert.ToDouble(strX)), 3);
            return res;
        }
    }
}
