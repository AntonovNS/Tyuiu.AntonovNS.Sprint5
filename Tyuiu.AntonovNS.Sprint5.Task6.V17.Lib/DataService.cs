using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AntonovNS.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
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
            return 2;
        }
    }
}
