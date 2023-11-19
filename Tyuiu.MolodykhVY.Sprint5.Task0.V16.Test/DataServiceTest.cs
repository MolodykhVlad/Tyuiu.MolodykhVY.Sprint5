using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint5.Task0.V16.Lib;
using System.IO;

namespace Tyuiu.MolodykhVY.Sprint5.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Vlad\source\repos\Tyuiu.MolodykhVY.Sprint5\Tyuiu.MolodykhVY.Sprint5.Task0.V16\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
