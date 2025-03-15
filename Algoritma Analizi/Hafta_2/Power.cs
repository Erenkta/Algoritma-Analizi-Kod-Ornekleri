using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Analizi.Hafta_2
{
    public class Power
    {
        public int PowerOfNumber(int a, int b)
        {
            int result = 1;
            int baseNum = a;   // İlk ekstra değişken
            int exponent = b;  // İkinci ekstra değişken

            while (exponent > 0)
            {
                result *= baseNum;
                exponent -= 1;
            }

            return result;
        }
    }
}
