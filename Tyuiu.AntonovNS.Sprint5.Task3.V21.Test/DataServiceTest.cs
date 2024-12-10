using System.IO;
using Tyuiu.AntonovNS.Sprint5.Task3.V21.Lib;
namespace Tyuiu.AntonovNS.Sprint5.Task3.V21.Test
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
            int x = 3;
            bool wait = false;
            string path1 = ds.SaveToFileTextData(x);
            Assert.AreEqual(wait, fileExists);
        }
    }
}