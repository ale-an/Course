namespace Module10;

public class Worker : IWorker
{
    public void Build()
    {
        throw new NotImplementedException();
    }
}

public interface IWorker
{
    public void Build();
}