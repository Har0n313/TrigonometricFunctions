using TrigonometricFunctions.Interface;

namespace TrigonometricFunctions.Classes
{
    public class FunctionCalculator
    {
        public static List<(double x, double y)> CalculateValues(ITrigonometricFunction function, double start, double end, double step, bool inDegrees)
        {
            var results = new List<(double, double)>();
            for (double x = start; x <= end; x += step)
            {
                double rad = inDegrees ? x * Math.PI / 180.0 : x;
                double y = function.Calculate(rad);
                results.Add((x, y));
            }
            return results;
        }
    }
}
