using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace LineCoordinatesCreatorByString.Encoding
{
    class PotentialCodeNRZ
    {
        public static ObservableCollection<LineByPoints> GetAllLinesCoordinates(string binaryCode)
        {
            ObservableCollection<LineByPoints> linesCoordinates = new ObservableCollection<LineByPoints>();

            int strokeThickness = Overall.StrokeThickness;
            int state = 0;
            int y = 40 * Overall.Scale;
            int x = 0;

            foreach (char bit in binaryCode)
            {
                if (bit.Equals('1'))
                {
                    if (state == 1)
                    {
                        linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x += Overall.HorizontalLineSize, y), strokeThickness));
                    }
                    else if (state == 0)
                    {
                        linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x, y -= (Overall.VerticalLineSize * 2)), strokeThickness));
                        linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x += Overall.HorizontalLineSize, y), strokeThickness));
                    }

                    state = 1;
                }
                else if (bit.Equals('0'))
                {
                    if (state == 1)
                    {
                        linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x, y += (Overall.VerticalLineSize * 2)), strokeThickness));
                        linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x += Overall.HorizontalLineSize, y), strokeThickness));
                    }
                    else if (state == 0)
                    {
                        linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x += Overall.HorizontalLineSize, y), strokeThickness));
                    }

                    state = 0;
                }
            }
            return linesCoordinates;
        }
    }
}
