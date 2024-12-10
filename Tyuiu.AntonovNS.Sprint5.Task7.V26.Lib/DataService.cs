using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AntonovNS.Sprint5.Task7.V26.Lib
{
    public class DataService : ISprint5Task7V26
    {
        public string LoadDataAndSave(string path)
        {
            double res = 0;
            int s = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line, out double number) && number >= 0)
                    {
                        res = res + number;
                        s++;
                    }

                }
            }
            return "2";
        }
    }
}
