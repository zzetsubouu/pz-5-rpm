using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_5_rpm
{
    internal class CircleArc
    {
        private double radius;
        private double angle;

        public double Angle { get => angle; set => angle = value; }
        public double Radius { get => radius; set => radius = value; }

        public CircleArc(double radius, double angle)
        {
            this.Radius = radius;
            this.Angle = angle;
        }

        public double LengthOfArc()
        {
            return radius * angle;
        }
        public override string ToString()
        {
            return $"Радиус = {radius}, угол в радианах = {angle}";
        }
    }
}
