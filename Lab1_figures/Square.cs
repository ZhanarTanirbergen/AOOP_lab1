using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_figures
{
    class Square : ISquareCalculatable
    {
        private double side;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                if(value <= 0)
                        throw new Exception("negative or zero value is passed.");
                side = value; 
            }
        }
        public double Area()
        {
            return side * side;
        }
        public override string ToString()
        {
            return string.Format("Square. Side: {0} area: {1}", side, Area());
        }
    }
}
