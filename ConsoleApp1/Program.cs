namespace ClassesTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PinMaker nn = new();
        }
    }
    public static class PinValidator
    {
    }
    public abstract class PinValidatorBase
    {
        protected int pin;
    }
    public class PinMaker : PinValidatorBase
    {
    }
    public interface IPinValidator
    {
        static int pin { get; set; }
    }
    public sealed class Validator : IPinValidator
    {
        int _pin;

    }
}
