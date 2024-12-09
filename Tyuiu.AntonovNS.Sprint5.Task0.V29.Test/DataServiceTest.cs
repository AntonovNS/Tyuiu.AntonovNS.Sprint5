using System.IO;
using Tyuiu.AntonovNS.Sprint5.Task0.V29.Lib;
namespace Tyuiu.AntonovNS.Sprint5.Task0.V29.Test
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
            string path1 = ds.SaveToFileTextData(x);
            Assert.AreEqual(wait, fileExists);
        }
    }
}