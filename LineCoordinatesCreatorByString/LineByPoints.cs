using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LineCoordinatesCreatorByString
{
    class LineByPoints
    {
        public Point First { get; set; }
        public Point Second { get; set; }
        public double StrokeThickness { get; set; }
        public LineByPoints(Point first, Point second, double strokeThickness)
        {
            First = first;
            Second = second;
            StrokeThickness = strokeThickness;
        }
    }
}
