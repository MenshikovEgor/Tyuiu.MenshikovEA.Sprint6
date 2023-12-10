using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MenshikovEA.Sprint6.Task4.V12.Lib
{
    public class DataService : ISprint6Task4V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] ValueArray;
            int len = (stopValue - startValue) + 1;
            ValueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x) + 2/(3 * x + 0.5) - 2 * Math.Cos(x) * 2 * x), 2);
                ValueArray[count] = y;
                count++;
            }

            return ValueArray;
        }
    }
}
