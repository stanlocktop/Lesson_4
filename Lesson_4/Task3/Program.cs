namespace Task3
{
    //    3) Доробити програму, яку розглядали на занятті (через використання методу і в ньому return)
    //Перевірка чи є введене натуральне число простим

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            / Random random = new Random();
            int gennum = random.next(2, 1000);

            int indicator = 1;
            for (int i = 2; i < gennum; i++)
            {
                if (gennum % i == 0)
                {
                    console.writeline("not simple");
                    indicator = 0;
                    break;
                }
            }
            if (indicator == 1)
            {
                console.writeline("simple");
            }
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.ResetColor(); // сбрасываем в стандартный
            Console.ReadKey();
        }
    }
}
