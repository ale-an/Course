using System.Diagnostics;

namespace Module13;

public class Practice
{
    public void Task_13_6_1()
    {
        var text = GetText();

        var list = new List<char>();
        var stopWatch = Stopwatch.StartNew();

        foreach (var symbol in text)
        {
            list.Add(symbol);
        }

        stopWatch.Stop();
        Console.WriteLine($"List.Add - {stopWatch.ElapsedMilliseconds} ms");

        var linkedList = new LinkedList<char>();
        stopWatch = Stopwatch.StartNew();

        foreach (var symbol in text)
        {
            linkedList.AddLast(symbol);
        }

        stopWatch.Stop();
        Console.WriteLine($"LinkedList.Add - {stopWatch.ElapsedMilliseconds} ms");

        // List.Add - 5 ms
        // LinkedList.Add - 119 ms
    }


    public void Task_13_6_2()
    {
        var text = GetText();

        var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c))
            .ToArray());

        char[] delimiters = {' ', '\r', '\n'};

        var words = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        var dictionary = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary[word]++;
            }
            else
            {
                dictionary.Add(word, 1);
            }
        }

        var result = new List<KeyValuePair<string, int>>();

        foreach (var element in dictionary)
        {
            result.Add(element);
        }

        for (var i = 0; i < result.Count; i++)
        {
            for (var j = 0; j < result.Count - 1 - i; j++)
            {
                if (result[j].Value < result[j + 1].Value)
                {
                    var tmp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = tmp;
                }
            }
        }

        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine($"{result[i].Key} - {result[i].Value}");
        }
    }

    private static string GetText()
    {
        string text;
        using (var sr = File.OpenText(@"C:\Users\tipoy\Downloads\book.txt"))
        {
            text = sr.ReadToEnd();
        }

        return text;
    }
}