using System;

namespace CalculateAverageLib
{
    public class AverageSolution
    {
        public static double FindAverage(double[] array)
        {
            if (array.Length == 0) return 0;

            double avg = 0;

            foreach (var d in array)
            {
                avg += d;
            }

            return avg / array.Length;
        }
    }
}
