namespace Module13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task_13_1_4(new[] {1, 2, 3});
            Task_13_1_6();
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
    }
}