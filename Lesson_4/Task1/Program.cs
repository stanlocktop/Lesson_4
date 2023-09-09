namespace Task1
{
//    1) Написати програму, яка перевіряє введене число на парність/непарність.

//13 -> "непарне"

//22 -> "парне"
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть число: ");
            int a = Convert.ToInt32(Console.Read());
            {
                if (a % 2 == 0) Console.WriteLine("Парне");
                else Console.WriteLine("Непарне");
            }
            Console.ReadKey();
        }
    }
}
