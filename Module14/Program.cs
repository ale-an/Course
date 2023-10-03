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
    }
}