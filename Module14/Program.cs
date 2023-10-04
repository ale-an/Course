using System.Net.Sockets;

namespace Module14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task_4();
            Task_8();
            Task_14_1_1();
            Task_14_1_2();
            Task_14_1_5();
            Task_14_1_6();
            Task_14_2_1();
            Task_14_2_3();
        }

        private static void Task_4()
        {
            string[] people = {"Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян"};
            var list = new List<string>();
            foreach (var person in people)
            {
                if (person[0] == 'А')
                {
                    list.Add(person);
                }
            }

            list.Sort();
        }

        private static void Task_8()
        {
            var objects = new List<object>()
            {
                1,
                "Сергей ",
                "Андрей ",
                300,
            };

            foreach (var element in objects.Where(x => x is string).OrderBy(x => x.ToString()).ToArray())
                Console.WriteLine(element);
        }

        private static void Task_14_1_1()
        {
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            var cities = russianCities
                .Where(y => y.Name.Length <= 10)
                .OrderBy(y => y.Name.Length);
            foreach (var city in cities)
            {
                Console.WriteLine(city.Name);
            }
        }

        private static void Task_14_1_2()
        {
            string[] text =
            {
                "Раз два три",
                "четыре пять шесть",
                "семь восемь девять"
            };

            var words = text.SelectMany(x => x.Split(' '));

            foreach (var word in words)
                Console.WriteLine(word);
        }

        private static void Task_14_1_5()
        {
            var companies = new Dictionary<string, string[]>();

            companies.Add("Apple", new[] {"Mobile", "Desktop"});
            companies.Add("Samsung", new[] {"Mobile"});
            companies.Add("IBM", new[] {"Desktop"});

            var mobileCompanies = companies.Where(x => x.Value.Contains("Mobile"));

            foreach (var mobileCompany in mobileCompanies)
                Console.WriteLine(mobileCompany.Key);
        }

        private static void Task_14_1_6()
        {
            var numsList = new List<int[]>()
            {
                new[] {2, 3, 7, 1},
                new[] {45, 17, 88, 0},
                new[] {23, 32, 44, -6},
            };

            var newList = numsList.SelectMany(x => x).OrderBy(x => x);

            foreach (var element in newList)
            {
                Console.WriteLine(element);
            }
        }

        private static void Task_14_2_1()
        {
            string[] words = {"Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха"};
            var animals = words.Select(x => new
            {
                Name = x,
            }).OrderBy(x => x.Name.Length);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }

        private static void Task_14_2_3()
        {
            List<Student> students = new List<Student>
            {
                new Student {Name = "Андрей", Age = 23, Languages = new List<string> {"английский", "немецкий"}},
                new Student {Name = "Сергей", Age = 27, Languages = new List<string> {"английский", "французский"}},
                new Student {Name = "Дмитрий", Age = 29, Languages = new List<string> {"английский", "испанский"}},
                new Student {Name = "Василий", Age = 24, Languages = new List<string> {"испанский", "немецкий"}}
            };

            var applications = from s in students
                where s.Age < 27
                let yearOfBirth = DateTime.Now.Year - s.Age
                select new Application()
                {
                    Name = s.Name,
                    YearOfBirth = yearOfBirth
                };
            foreach (var sApplication in applications)
            {
                Console.WriteLine(sApplication.Name + ", " + sApplication.YearOfBirth);
            }
        }
    }
}