using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint5.Task3.V23.Lib;
using System.IO;

namespace Tyuiu.MolodykhVY.Sprint5.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedFile()
        {
            string path = @"C:\Users\Vlad\source\repos\Tyuiu.MolodykhVY.Sprint5\Tyuiu.MolodykhVY.Sprint5.Task3.V23\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

        }
    }
}
