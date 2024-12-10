using System.IO;
using Tyuiu.AntonovNS.Sprint5.Task1.V1.Lib;
namespace Tyuiu.AntonovNS.Sprint5.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            int x = 3;
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            string path1 = ds.SaveToFileTextData(-5, 5);
            Assert.AreEqual(wait, fileExists);
        }
    }
}