using System.Net.Sockets;

namespace Module15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task_15_1_4();
            Task_15_1_5();
            Task_15_1_6();
            Task_15_2_1(5);
            Task_15_2_2();
            Task_15_2_3(new[] {1, 2, 3, 4});
            Task_15_2_8();
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

        private static void Task_15_1_6()
        {
            char[] marks = {' ', ',', '.', ';', ':', '?', '!'};

            Console.WriteLine("Напишите что-нибудь");
            var suggestion = Console.ReadLine();

            if (string.IsNullOrEmpty(suggestion))
            {
                Console.WriteLine("Попытайтесь ещё");
                return;
            }

            var symbols = suggestion.Except(marks).Distinct().Count();

            Console.WriteLine($"Уникальных символов: {symbols}");
        }

        static long Task_15_2_1(int number)
        {
            var numbers = new List<long>();

            for (int i = 1; i <= number; i++)
            {
                numbers.Add(i);
            }

            return numbers.Aggregate((x, y) => x * y);
        }

        private static void Task_15_2_2()
        {
            var contacts = new List<Contact>()
            {
                new Contact() {Name = "Андрей", Phone = 79994500508},
                new Contact() {Name = "Сергей", Phone = 799990455},
                new Contact() {Name = "Иван", Phone = 79999675334},
                new Contact() {Name = "Игорь", Phone = 8884994},
                new Contact() {Name = "Анна", Phone = 665565656},
                new Contact() {Name = "Василий", Phone = 3434}
            };

            var incorrectContacts =
                contacts.Count(s => s.Phone.ToString().Length != 11 || s.Phone.ToString()[0] != '7');

            Console.WriteLine($"Неверных номеров телефонов: {incorrectContacts}");
        }

        static double Task_15_2_3(int[] numbers)
        {
            return numbers.Sum() / (double) numbers.Length;
        }

        private static void Task_15_2_8()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Введите число, пожалуйста");
                var text = Console.ReadLine();

                if (string.IsNullOrEmpty(text))
                {
                    continue;
                }

                if (!int.TryParse(text, out var number))
                {
                    continue;
                }

                numbers.Add(number);

                var count = numbers.Count;
                var sum = numbers.Sum();
                var max = numbers.Max();
                var min = numbers.Min();
                var average = numbers.Average();

                Console.WriteLine($"Чисел в списке: {count}");
                Console.WriteLine($"Сумма всех чисел: {sum}");
                Console.WriteLine($"Наибольшее число: {max}");
                Console.WriteLine($"Наименьшее число: {min}");
                Console.WriteLine($"Среднее значение: {average}");
            }
        }
    }
}