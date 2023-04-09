
namespace Module16
{
    public class Calculator
    {
        public int Multiplication(int a, int b)
        {
            long result = (long) a * b;
            CheckResultForOverflow(result);
            return (int)result;
        }

        public int Division(int a, int b)
        {
            long result = (long) a / b;
            CheckResultForOverflow(result);
            return (int)result;
        }

        public int Substraction(int a, int b)
        {
            long result = (long) a - b;
            CheckResultForOverflow(result);
            return (int)result;
        }

        public int Summation(int a, int b)
        {
            long result = (long)a + b;
            CheckResultForOverflow(result);
            return (int)result;
        }

        private static void CheckResultForOverflow(long result)
        {
            if (result > int.MaxValue || result < int.MinValue)
            throw new OverflowException("Operation caused an overflow");
        }
    }
}
