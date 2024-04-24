namespace ConsoleApp1
{
    class Calculator
    {
        private double a;
        private double b;

        public void SetA(double value)
        {
            a = value;
        }

        public void SetB(double value)
        {
            b = value;
        }
        public double Multiply()
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Ввести А");
                Console.WriteLine("2. Ввести В");
                Console.WriteLine("5. Выполнить операцию \"*\"");
                Console.WriteLine("0. Выход");

                Console.Write("Выберите пункт меню: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите значение А: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        calculator.SetA(a);
                        break;
                    case "2":
                        Console.Write("Введите значение В: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        calculator.SetB(b);
                        break;
                    case "5":
                        double product = calculator.Multiply();
                        Console.WriteLine("Результат: " + product);
                        break;
                    case "0":
                        Console.WriteLine("Выход из программы.");
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
