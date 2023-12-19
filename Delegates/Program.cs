namespace Delegates
{
    delegate int CalculatorDelegate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorDelegate calculatorDelegate = Add;

            int choice, num1, num2, result;

            Console.WriteLine("Vælg en operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraktion (-)");
            Console.WriteLine("------------------------");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    calculatorDelegate = Add;
                    break;
                case 2:
                    calculatorDelegate = Sub;
                    break;
                default:
                    break;
            }
            Console.Clear();
            Console.WriteLine("Indtast første heltal: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast andet heltal: ");
            num2 = int.Parse(Console.ReadLine());

            result = calculatorDelegate(num1, num2);
            Console.Clear();
            Console.WriteLine($"Resultatet er: {result}");

        }

        static int Add(int a, int b) { return a + b; }
        static int Sub(int a, int b) {  return a - b; }
    }
}
