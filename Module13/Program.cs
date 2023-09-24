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
            Task_13_2_6(new ArrayList {1, "string1", 2, "string2"});
            Task_13_3_5();
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
    }
}