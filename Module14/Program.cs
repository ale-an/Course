using System.Net.Sockets;

namespace Module14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task_4();
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
    }
}