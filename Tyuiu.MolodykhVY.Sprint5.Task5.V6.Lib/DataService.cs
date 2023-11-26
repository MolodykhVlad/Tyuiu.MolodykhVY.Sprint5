using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolodykhVY.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            double x = Convert.ToDouble(str);
            double res = (1/Math.Cos(x)) + Math.Pow(x,2) * 2.2;
            return Math.Round(res, 3);
        }
    }
}
