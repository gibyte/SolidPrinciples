using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class RandomValue : IRandomValue
    {
        public int GetValue(int maxVal, int minVal = 1)
        {
            Random rnd = new();
            return  rnd.Next(minVal, maxVal);
        }
    }
}
