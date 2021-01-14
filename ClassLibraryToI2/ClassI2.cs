using System;

namespace ClassLibraryToI2
{
    public class ClassI2
    {
        private string number;
        private string degree;
        public ClassI2(string number, string degree)
        {
            this.number = number;
            this.degree = degree;
        }
        public string GetResult()
        {
            return "" + Math.Pow(Double.Parse(number), Double.Parse(degree));
        }
        public string Clear()
        {
            return "";
        }
        public bool Check()
        {
            bool Flag = false;
            if (number.Length == 0 || degree.Length == 0 || number.Length > 10 || degree.Length > 10)
            {
                Flag = true;
            }
            return Flag;
        }
        
    }
}
