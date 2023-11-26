using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MolodykhVY.Sprint5.Task4.V6.Lib;
namespace Tyuiu.MolodykhVY.Sprint5.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V6.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool FileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExists);
        }
    }
}
