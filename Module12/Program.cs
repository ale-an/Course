namespace Module12;

class Program
{
    static void Main(string[] args)
    {
        Task_12_1_2();
        Task_12_1_3();
        Task_12_1_4();
        Task_12_1_5();
        Task_12_3_3();
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

    private static void Task_12_1_5()
    {
        var users = new User[2]
        {
            new User
            {
                Login = "login1",
                Name = "name1",
                IsPremium = true
            },
            new User
            {
                Login = "login2",
                Name = "name2",
                IsPremium = false
            }
        };
        foreach (var user in users)
        {
            Console.WriteLine($"Привет, {user.Name}");
            if (user.IsPremium == false)
            {
                ShowAds();
            }
        }
    }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }

    private static int BinarySearch(int value, int[] array, int left, int right)
    {
        while (left <= right)
        {
            var middle = (left + right) / 2;

            var midElement = array[middle];

            if (midElement == value)
            {
                return middle;
            }

            if (value < midElement)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return -1;
    }

    private static void Task_12_3_3()
    {
        Console.WriteLine(FindIndex(new[] {1, 2, 3, 5}, 4));
    }

    private static int FindIndex(int[] array, int value)
    {
        for (var i = 0; i < array.Length; i++)
        {
            if (value < array[i])
                return i;
        }

        return -1;
    }
}