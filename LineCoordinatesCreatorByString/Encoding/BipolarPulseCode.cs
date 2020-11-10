using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace LineCoordinatesCreatorByString.Encoding
{
    class BipolarPulseCode
    {
        public static ObservableCollection<LineByPoints> GetAllLinesCoordinates(string binaryCode)
        {
            ObservableCollection<LineByPoints> linesCoordinates = new ObservableCollection<LineByPoints>();

            int x = 0;
            int y = Overall.Middle * Overall.Scale;
            int strokeThickness = Overall.StrokeThickness;

            foreach (char bit in binaryCode)
            {
                if (bit.Equals('1'))
                {
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x, y -= Overall.VerticalLineSize), strokeThickness));
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x += Overall.HorizontalLineSize / 2, y), strokeThickness));
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x, y += Overall.VerticalLineSize), strokeThickness));
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x += Overall.HorizontalLineSize / 2, y), strokeThickness));
                }
                else if (bit.Equals('0'))
                {
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x, y += Overall.VerticalLineSize), strokeThickness));
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x += Overall.HorizontalLineSize / 2, y), strokeThickness));
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x, y -= Overall.VerticalLineSize), strokeThickness));
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x += Overall.HorizontalLineSize / 2, y), strokeThickness));
                }
            }
            return linesCoordinates;
        }
    }
}
