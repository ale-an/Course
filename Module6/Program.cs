namespace Module6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Чёрный";
            cost = 100;
        }

        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }
}