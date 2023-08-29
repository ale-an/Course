namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();

            ((IWriter) writer).Write();

            var worker = new Worker();

            ((IWorker) worker).Build();

            IUpdater<Account> updater = new UserService();
        }
    }

    public interface IManager
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }

    public class Manager : IManager
    {
        public void Create()
        {
        }

        public void Read()
        {
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }
    }
}