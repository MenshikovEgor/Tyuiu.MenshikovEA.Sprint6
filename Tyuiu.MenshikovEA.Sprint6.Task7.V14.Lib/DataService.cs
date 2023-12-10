using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.MenshikovEA.Sprint6.Task7.V14.Lib
{
    public class DataService : ISprint6Task7V14
    {
        public int len = 0;
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] mtrx = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    mtrx[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            int len = mtrx.GetLength(0);
            for (int i = 0; i <= len - 1; i++)
            {
                if (mtrx[2, i] % 2 == 0)
                {
                    mtrx[2, i] = 44;
                }
            }
            return mtrx;
        }
    }
}
