using TrigonometricFunctions.Interface;

namespace TrigonometricFunctions.Classes
{
    public abstract class TrigonometricFunctionBase : ITrigonometricFunction
    {
        public abstract string Name { get; }
        public abstract double Calculate(double x);
    }
}
