using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkUOG_Quiz
{
    public class RoundedCalculator : ICalculator
    {
        public double divide(double a, double b)
        {
            return Math.Round(a / b, 2);
        }

        public double mutliply(double a, double b)
        {
            return Math.Round(a * b, 2);
        }


    }
}
