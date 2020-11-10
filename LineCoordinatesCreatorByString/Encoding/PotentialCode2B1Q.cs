using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace LineCoordinatesCreatorByString.Encoding
{
    class PotentialCode2B1Q
    {
        public static ObservableCollection<LineByPoints> GetAllLinesCoordinates(string binaryCode)
        {
            ObservableCollection<LineByPoints> linesCoordinates = new ObservableCollection<LineByPoints>();


            int x = 0;
            int y = Overall.Middle * Overall.Scale;
            int strokeThickness = Overall.StrokeThickness;

            binaryCode = binaryCode.Replace(" ", String.Empty);

            for (int index = 0; index < binaryCode.Length; index += 2)
            {
                linesCoordinates.Add(new LineByPoints(new Point(x, Overall.Middle * Overall.Scale), new Point(x + 2 * Overall.HorizontalLineSize, Overall.Middle * Overall.Scale), 0.5));
                if (binaryCode[index].Equals('0') && binaryCode[index + 1].Equals('0'))
                {
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x, y = 100), strokeThickness));
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x += 2 * Overall.HorizontalLineSize, y), strokeThickness));
                }
                else if (binaryCode[index].Equals('0') && binaryCode[index + 1].Equals('1'))
                {
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x, y = 80), strokeThickness));
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x += 2 * Overall.HorizontalLineSize, y), strokeThickness));
                }
                else if (binaryCode[index].Equals('1') && binaryCode[index + 1].Equals('0'))
                {
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x, y = 40), strokeThickness));
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x += 2 * Overall.HorizontalLineSize, y), strokeThickness));
                }
                else if (binaryCode[index].Equals('1') && binaryCode[index + 1].Equals('1'))
                {
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x, y = 20), strokeThickness));
                    linesCoordinates.Add(new LineByPoints(new Point(x, y), new Point(x += 2 * Overall.HorizontalLineSize, y), strokeThickness));
                }
            }
            return linesCoordinates;
        }
    }
}
