namespace Task1
{
    //    2) Програма загадує число від 1 до 146 (привіт, Random). Користувач намагається вгадати його. У разі неправильної відповіді програма підказує «більше» або «менше»
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Random random = new Random();
            int secretNumber = random.Next(1, 147);

            Console.WriteLine("Привіт! Я загадав число від 1 до 146. Спробуйте вгадати!");

            int attempts = 0;
            int guess;

            do
            {
                Console.Write("Ваша спроба: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    attempts++;

                    string hint = guess < secretNumber ? "більше" : (guess > secretNumber ? "менше" : $"Вітаємо! Ви вгадали число {secretNumber} за {attempts} спроб.");
                    Console.WriteLine(hint);
                }
                else
                {
                    Console.WriteLine("Введено некоректне число. Спробуйте ще раз.");
                }

            } while (guess != secretNumber);

            Console.WriteLine("Гра завершена. Дякуємо за гру!");
            Console.ReadKey();
        }
    }
}
