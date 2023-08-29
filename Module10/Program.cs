using Module10.Practice;

namespace Module10
{
    class Program
    {
        static ILogger Logger { get; set; }

        static void Main(string[] args)
        {
            WorkerMethod();
            UpdaterMethod();

            Logger = new Logger();

            var calculatorService = new CalculatorService(Logger);
            calculatorService.Sum();
        }

        private static void UpdaterMethod()
        {
            IUpdater<Account> updater = new UserService();
        }

        private static void WorkerMethod()
        {
            Writer writer = new Writer();

            ((IWriter) writer).Write();

            var worker = new Worker();

            ((IWorker) worker).Build();
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