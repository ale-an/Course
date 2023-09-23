using System.Collections;
using System.Net.Sockets;

namespace Module13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task_13_1_4(new[] {1, 2, 3});
            Task_13_1_6();
            Task_13_2_5();
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
    }
}