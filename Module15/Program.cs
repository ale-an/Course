namespace Module15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task_15_1_4();
        }

        private static void Task_15_1_4()
        {
            Console.WriteLine("Введите первое слово");
            var word1 = Console.ReadLine();
            Console.WriteLine("Введите второе слово");
            var word2 = Console.ReadLine();
            var sameSymbol = word2.Intersect(word1);

            foreach (var s in sameSymbol)
            {
                Console.WriteLine(s);
            }
        }
    }
}