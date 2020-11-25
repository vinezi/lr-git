using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary2
{
    public class helper
    {
        private string value1;
        private string value2;
        public helper(string value1, string value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }
        public string GetLog()
        {
            return "" + Math.Log(Double.Parse(value1), Double.Parse(value2));
        }
        public string GetClear()
        {
            return "";
        }
        public bool IsEmpty()
        {
            bool Flag = false;
            if (value1.Length == 0 || value2.Length == 0)
            {
                Flag = true;
            }
            return Flag;
        }


    }
}
