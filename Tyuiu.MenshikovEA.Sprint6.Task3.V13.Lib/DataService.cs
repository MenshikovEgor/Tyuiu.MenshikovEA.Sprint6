using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MenshikovEA.Sprint6.Task3.V13.Lib
{
    public class DataService : ISprint6Task3V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] column = new int[5];
            
            for (int i = 0; i <= 4; i++)
            {
                column[i] = matrix[i, 1];
            }

            Array.Sort(column);

            for (int i = 0; i <= 4; i++)
            {
                matrix[i, 1] = column[i];
            }

            return matrix;
        }
    }
}
