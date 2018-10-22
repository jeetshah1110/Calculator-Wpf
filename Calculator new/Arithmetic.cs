using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Arithmetic
    {
        public int no1, no2, no3;

        public Arithmetic()
        {
            no1 = 0;
            no2 = 0;
            no3 = 0;
        }
        public Arithmetic(int val1, int val2)
        {
            no1 = val1;
            no2 = val2;
        }
        public Arithmetic(int val1)
        {
            no3 = val1;
        }
        public int Add()
        {
            return no1 + no2;

        }
        public int Sub()
        {
            return no1 - no2;

        }
        public int mul()
        {
            return no1 * no2;

        }
        public int div()
        {
            return no1 / no2;
        }
        public string ConvertBin()
        {
            String Bin = Convert.ToString(no3, 2);
            return Bin;
        }
        public string ConvertOct()
        {
            String Bin = Convert.ToString(no3, 8);
            return Bin;
        }
        public string ConvertHex()
        {
            String Bin = Convert.ToString(no3, 16);
            return Bin;
        }
    }
}
