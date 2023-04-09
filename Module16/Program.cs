namespace Module16
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Multiplication(2147483647, 2));
        }
    }
}