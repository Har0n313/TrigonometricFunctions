namespace TrigonometricFunctions.Interface
{
    public interface ITrigonometricFunction
    {
        string Name { get; }
        double Calculate(double x);
    }
}
