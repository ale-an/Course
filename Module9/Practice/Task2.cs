namespace Module9.Practice;

public class Task2
{
    private string[] people = new string[5]
    {
        "Головин",
        "Лавров",
        "Миронов",
        "Кузнецов",
        "Белоусов",
    };

    public void Show()
    {
        NumberReader numberReader = new NumberReader();
        numberReader.NumberEnteredEvent += ShowArray;

        while (true)
        {
            try
            {
                numberReader.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public void ShowArray(int number)
    {
        switch (number)
        {
            case 1:
                people = people.OrderBy(x => x).ToArray();
                break;
            case 2:
                people = people.OrderByDescending(x => x).ToArray();
                break;
        }

        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }
}

class NumberReader
{
    public delegate void NumberEnteredDelegate(int number);

    public event NumberEnteredDelegate NumberEnteredEvent;

    public void Read()
    {
        Console.WriteLine();
        Console.WriteLine("Необходимо ввести значение либо 1, либо 2");

        int number = Convert.ToInt32(Console.ReadLine());
        if (number != 1 && number != 2) throw new WrongNumberException("Введено некорректное значение");
        
        NumberEntered(number);
    }

    protected virtual void NumberEntered(int number)
    {
        NumberEnteredEvent?.Invoke(number);
    }
}