using System.Collections;
using System.Diagnostics;
using System.Net.Sockets;

namespace Module13
{
    public class Program
    {
        public static Stack<string> words = new Stack<string>();

        static void Main(string[] args)
        {
            Task_13_1_4(new[] {1, 2, 3});
            Task_13_1_6();
            Task_13_2_5();
            Task_13_2_6(new ArrayList {1, "string1", 2, "string2"});
            Task_13_3_5();
            Task_13_3_10();
            Task_13_3_12();
            Task_13_4_4();
            Task_13_4_5();
            Task_13_5_4();
        }


        private static bool Task_13_1_4(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        private static void Task_13_1_6()
        {
            string text;
            using (var sr = File.OpenText(@"C:\Users\tipoy\Downloads\book.txt"))
            {
                text = sr.ReadToEnd();
            }

            var count = 0;
            var currentWord = "";

            foreach (var symbol in text)
            {
                if (symbol is ' ' or '\r' or '\n')
                {
                    if (currentWord.Length == 0)
                        continue;

                    currentWord = "";
                    count++;
                }
                else
                    currentWord += symbol;
            }

            Console.WriteLine(count);
        }

        private static void Task_13_2_5()
        {
            var months = new[]
            {
                "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            var numbers = new[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };
            var arrayList = new ArrayList();
            for (int i = 0; i < 12; i++)
            {
                arrayList.Add(months[i]);
                arrayList.Add(numbers[i]);
            }

            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }
        }

        private static ArrayList Task_13_2_6(ArrayList input)
        {
            var number = 0;
            var str = "";

            foreach (var element in input)
            {
                var stringElement = element.ToString();

                if (int.TryParse(stringElement, out var result))
                    number += result;
                else
                    str += stringElement;
            }

            return new ArrayList()
            {
                number,
                str
            };
        }

        private void AddUnique(Contact contact, List<Contact> phoneBook)
        {
            var flag = false;

            foreach (var element in phoneBook)
            {
                if (contact.Name == element.Name &&
                    contact.PhoneNumber == element.PhoneNumber &&
                    contact.Email == element.Email)
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                phoneBook.Add(contact);
            }

            phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

            foreach (var element in phoneBook)
                Console.WriteLine(element.Name + ": " + element.PhoneNumber);
        }

        private static void Task_13_3_5()
        {
            var months = new List<string>()
            {
                "Jan", "Feb", "Mar", "Apr", "May"
            };
            var missing = new ArrayList()
            {
                1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };
            var cut = missing.GetRange(4, 7);
            foreach (var element in cut)
            {
                months.Add(element.ToString());
            }
        }

        private static void Task_13_3_10()
        {
            var text = Console.ReadLine();

            var hashset = new HashSet<char>();

            hashset.UnionWith(text);

            Console.WriteLine(hashset.Count);

            var numbers = new[]
            {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            var marks = new[]
            {
                ' ', ',', '!', '?', ';', '-', '—', ':', '.'
            };

            foreach (var set in hashset)
            {
                foreach (var number in numbers)
                {
                    if (set == number)
                    {
                        Console.WriteLine("Цифра есть!");
                        break;
                    }
                }
            }

            hashset.ExceptWith(marks);
            Console.WriteLine($"Символов без знаков препинания: {hashset.Count}");
        }

        private static void Task_13_3_12()
        {
            while (true)
            {
                Task_13_3_10();
            }
        }

        private static void Task_13_4_5()
        {
            var stopWatch = Stopwatch.StartNew();
            var dictionary = new SortedDictionary<string, ContactDict>();

            dictionary.Add("Алена", new ContactDict(79995692122, "alena@mail.ru"));
            dictionary.Add("Мурат", new ContactDict(79651231232, "murat@mail.ru"));

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key} - {dictionary[key].PhoneNumber} - {dictionary[key].Email}");
            }

            dictionary.Add("Гордей", new ContactDict(79124322233, "gordey@mail.ru"));

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key} - {dictionary[key].PhoneNumber} - {dictionary[key].Email}");
            }

            dictionary["Гордей"].PhoneNumber = 0;

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key} - {dictionary[key].PhoneNumber} - {dictionary[key].Email}");
            }

            stopWatch.Stop();
            Console.WriteLine($"SortedDictionary - {stopWatch.ElapsedMilliseconds} ms");
        }

        private static void Task_13_4_4()
        {
            var stopWatch = Stopwatch.StartNew();
            var dictionary = new Dictionary<string, ContactDict>();

            dictionary.Add("Алена", new ContactDict(79995692122, "alena@mail.ru"));
            dictionary.Add("Мурат", new ContactDict(79651231232, "murat@mail.ru"));

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key} - {dictionary[key].PhoneNumber} - {dictionary[key].Email}");
            }

            dictionary.Add("Гордей", new ContactDict(79124322233, "gordey@mail.ru"));

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key} - {dictionary[key].PhoneNumber} - {dictionary[key].Email}");
            }

            dictionary["Гордей"].PhoneNumber = 0;

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key} - {dictionary[key].PhoneNumber} - {dictionary[key].Email}");
            }

            stopWatch.Stop();
            Console.WriteLine($"Dictionary - {stopWatch.ElapsedMilliseconds} ms");
        }

        private static void Task_13_5_4()
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "pop":
                        words.TryPop(out _);
                        break;
                    case "peek":
                        if (words.TryPeek(out var peek))
                            Console.WriteLine(peek);
                        break;
                    default:
                        words.Push(input);
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }
        }
    }
}