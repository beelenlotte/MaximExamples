using ASPnetCoreSyntraExample.Services.Interfaces;

namespace ASPnetCoreSyntraExample.Services
{
    public class CalculatorService : ICalculator
    {
        public int Multiply(int g1, int g2)
        {
            return g1 * g2;
        }

        public int Subtract(int g1, int g2)
        {
            return g1 - g2;
        }

        public int Sum(int g1, int g2)
        {
            return g1 + g2;
        }
    }
}