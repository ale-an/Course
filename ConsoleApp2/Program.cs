namespace ConsoleApp2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Задания();
            Анкета();
            Цвета();
        }

        public static void Задания()
        {
            const string MyName = "Jane";

            Console.WriteLine(MyName);

            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\u0023");
            Console.ReadKey();
        }

        public static void Анкета()
        {
            const string MyName = "Alena";
            Console.WriteLine("My name is " + MyName);

            byte MyAge = 23;
            Console.WriteLine("My age is " + MyAge);

            bool HaveIApet = false;
            Console.WriteLine("Do I have a pet? " + HaveIApet);

            float MyShoeSize = 38;
            Console.WriteLine("My shoe size is " + MyShoeSize);
        }
        public static void Цвета()
        {

        }
    }


    enum Semaphore : short
    {
        Red = 100,
        Yellow,
        Green,
    }


}
