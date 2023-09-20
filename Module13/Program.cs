namespace Module13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task_13_1_4(new[] {1, 2, 3});
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
    }
}