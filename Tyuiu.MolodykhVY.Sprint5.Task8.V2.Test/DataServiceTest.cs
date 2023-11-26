using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint5.Task7.V2.Lib;
using System.IO;
namespace Tyuiu.MolodykhVY.Sprint5.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedfileExist()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileex = fileInfo.Exists;
            Assert.AreEqual(fileex, true);
        }
    }
}
