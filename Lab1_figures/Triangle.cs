using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_figures
{
    class Triangle
    {
        private double a, b, angle;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("negative or zero value is passed.");
                a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("negative or zero value is passed.");
                b = value;
            }
        }
        public double Angle
        {
            get
            {
                return angle;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("negative or zero value is passed.");
                angle = value;
            }
        }
        public double Area()
        {
            double rdn = Math.Sin(angle * Math.PI / 180);
            return 0.5 * a * b * rdn;
        }
        public override string ToString()
        {
            return string.Format("Triangle. a: {0}  b {1}  angle {2} area: {3}", a, b, angle, Area());
        }

    }
}
