namespace Module15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task_15_1_4();
            Task_15_1_5();
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

        private static void Task_15_1_5()
        {
            var softwareManufacturers = new List<string>()
            {
                "Microsoft", "Apple", "Oracle"
            };
 
            var hardwareManufacturers = new List<string>()
            {
                "Apple", "Samsung", "Intel"
            };

            var itCompanies = softwareManufacturers.Union(hardwareManufacturers);

            foreach (var c in itCompanies)
            {
                Console.WriteLine(c);
            }
        }
    }
}