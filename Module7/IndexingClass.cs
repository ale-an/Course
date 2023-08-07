namespace Module7;

public class IndexingClass
{
    private int[] array;

    public IndexingClass(int[] array)
    {
        this.array = array;
    }

    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < array.Length)
            {
                return array[index];
            }
            else
            {
                return 0;
            }
        }

        private set
        {
            if (index >= 0 && index < array.Length)
            {
                array[index] = value;
            }
        }
    }
}