using System.Net.Sockets;

namespace Module14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task_4();
            Task_8();
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
    }
}