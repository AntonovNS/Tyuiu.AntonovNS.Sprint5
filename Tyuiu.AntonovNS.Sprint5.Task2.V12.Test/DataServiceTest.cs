using System.IO;
using Tyuiu.AntonovNS.Sprint5.Task2.V12.Lib;
namespace Tyuiu.AntonovNS.Sprint5.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            int[,] x = { { -5, -5, 9 }, { -7, 3, -4 }, { 8, 7, 9 } };
            string path1 = ds.SaveToFileTextData(x);
            Assert.AreEqual("0;0;1\n0;1;0\n1;1;1", path1);
        }
    }
}