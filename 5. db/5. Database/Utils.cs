using System;

namespace Collections2
{
    public class Utils
    {
        public static int CalcLen(double x1, double x2, double y1, double y2)
        {
            return ((int) Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)),
                MidpointRounding.AwayFromZero));
        }
    }
}