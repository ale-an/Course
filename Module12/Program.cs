namespace Module12;

class Program
{
    static void Main(string[] args)
    {
        Task_12_1_2();
        Task_12_1_3();
        Task_12_1_4();
    }


    private static void Task_12_1_2()
    {
        Console.WriteLine("Как Вас зовут?");
        var name = Console.ReadLine();
        var greetings = "Привет" + name;
        Console.WriteLine(greetings);
    }

    private static void Task_12_1_3()
    {
        Console.WriteLine("Сколько элементов будет в массиве?");
        var count = Convert.ToInt32(Console.ReadLine());
        var array = new string [count];
        for (int i = 0; i < count; i++)
        {
            array[i] = Console.ReadLine();
        }

        Console.WriteLine("Все элементы записаны");
    }

    private static void Task_12_1_4()
    {
        Console.WriteLine("Введите свой возраст");
        var age = Convert.ToInt32(Console.ReadLine());
        if (age > 13)
        {
            Console.WriteLine("Вы успешно зарегистрированы");
        }
        else
        {
            Console.WriteLine("Пользователи младше 14 лет не могут быть зарегистрированы");
        }
    }
}