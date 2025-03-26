namespace TrigonometricFunctions.Classes
{
    public class SinFunction : TrigonometricFunctionBase
    {
        public override string Name => "Sin";
        public override double Calculate(double x) => Math.Sin(x);
    }

    public class CosFunction : TrigonometricFunctionBase
    {
        public override string Name => "Cos";
        public override double Calculate(double x) => Math.Cos(x);
    }

    public class TgFunction : TrigonometricFunctionBase
    {
        public override string Name => "Tg";
        public override double Calculate(double x)
        {
            if (Math.Abs(Math.Cos(x)) < double.Epsilon)
                throw new ArgumentException("Тангенс не определен для данного угла");
            return Math.Tan(x);
        }
    }

    public class CtgFunction : TrigonometricFunctionBase
    {
        public override string Name => "Ctg";
        public override double Calculate(double x)
        {
            if (Math.Abs(Math.Sin(x)) < double.Epsilon)
                throw new ArgumentException("Котангенс не определен для данного угла");
            return 1.0 / Math.Tan(x);
        }
    }
}
