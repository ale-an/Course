using System.Security.Cryptography.X509Certificates;

namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_4_1_4();
            Task_4_1_5();
            Task_4_1_12();
        }
        private static void Task_4_1_4()
        {
            string A;
            string B;
            //bool C = A != B;
        }
        private static void Task_4_1_5()
        {
            int A;
            int B;
            double X;
            double Y;
            //bool C = (A < B) | (X > Y);
        }
        private static void Task_4_1_12()
        {
            var a = 7;
            var b = 7;

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            };
        }

    }
}