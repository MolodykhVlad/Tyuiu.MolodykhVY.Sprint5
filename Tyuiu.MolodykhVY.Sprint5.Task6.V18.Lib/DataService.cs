using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MolodykhVY.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int j = 0;
                    foreach (char i in line)
                    {
                        if (Char.IsLetter(i)) j += 1;
                        else
                        {
                            if (j == 1)
                            {
                                res += 1;
                                j = 0;
                            }
                            else j = 0;
                        }
                    }
                }
                return res;
            }
        }
    }
}
